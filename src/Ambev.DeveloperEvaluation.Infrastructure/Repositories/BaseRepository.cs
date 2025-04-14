using Ambev.DeveloperEvaluation.Domain.Base;
using Ambev.DeveloperEvaluation.Domain.Base.Interfaces;
using Ambev.DeveloperEvaluation.Domain.Exceptions;
using Ambev.DeveloperEvaluation.Infrastructure.Contexts;
using Ambev.DeveloperEvaluation.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories;

[ExcludeFromCodeCoverage]
public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
{
    protected readonly PostgreDbContext _dbContext;
    private readonly ILogger<BaseRepository<T>> _logger;

    public BaseRepository(PostgreDbContext dbContext, ILogger<BaseRepository<T>> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task<PagedResult<T>> GetAsync(int page = 1,
                                               int maxResults = 10,
                                               Expression<Func<T, bool>>? criteria = default,
                                               string? orderByClause = default)
    {
        page = page == 0 ? 1 : page;
        int count = (page - 1) * maxResults;

        IQueryable<T> query = _dbContext.Set<T>().AsQueryable();

        if (criteria is not null)
            query = query.Where(criteria);

        if (!string.IsNullOrWhiteSpace(orderByClause))
            query = query.ApplyOrdering(orderByClause);

        var totalRecords = await query.CountAsync();
        var items = await query.Skip(count).Take(maxResults).ToListAsync();

        return new PagedResult<T>(totalRecords, items);
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<T> AddAsync(T entity)
    {
        try
        {
            _logger.LogInformation("Adding a new entity of type {EntityType}", typeof(T).Name);
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            _logger.LogInformation("Entity of type {EntityType} added successfully with ID {EntityId}", typeof(T).Name, entity.Id);
            return entity;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while adding an entity of type {EntityType}", typeof(T).Name);
            throw;
        }
    }

    public async Task DeleteAsync(T entity)
    {
        if (entity.IsDeleted)
            throw new EntityAlreadyDeletedException("The entity is already deleted.");

        entity.IsDeleted = true;

        _dbContext.Set<T>().Update(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();

        return entity;
    }
}