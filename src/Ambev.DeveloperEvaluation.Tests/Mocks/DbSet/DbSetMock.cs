using Microsoft.EntityFrameworkCore;
using NSubstitute;

namespace Ambev.DeveloperEvaluation.Tests.Mocks.DbSetup;

public static class DbSetMock
{
    public static DbSet<T> Create<T>(IEnumerable<T> elements) where T : class
    {
        var queryable = elements.AsQueryable();
        var dbSet = Substitute.For<DbSet<T>, IQueryable<T>>();

        ((IQueryable<T>)dbSet).Provider.Returns(queryable.Provider);
        ((IQueryable<T>)dbSet).Expression.Returns(queryable.Expression);
        ((IQueryable<T>)dbSet).ElementType.Returns(queryable.ElementType);
        ((IQueryable<T>)dbSet).GetEnumerator().Returns(queryable.GetEnumerator());

        return dbSet;
    }
}
