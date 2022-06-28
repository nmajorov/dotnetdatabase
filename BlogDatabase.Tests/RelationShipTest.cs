using System.Linq;
using Xunit;
using BlogDatabase;
using database;

namespace BlogDatabase.Tests;

/**
 * test database relationship
 */
public class RelationShipTest
{
    [Fact]
    public void Test1()
    {
        using var db = new BloggingContext();
        var posts = db.Posts?.Count();
        Assert.True(posts > 0);
    }
}