using LookAtMe.Core;

namespace LookAtMe.Tests;

public class PlayerSearchTests
{
    [Theory]
    [InlineData("Alice Moon", "ali")]
    [InlineData("Alice Moon", "MOON")]
    [InlineData("Alice Moon", "  ce Mo ")]
    public void MatchesSubstringIgnoringCase(string name, string query) =>
        Assert.True(PlayerSearch.Matches(name, query));

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData("Bob")]
    public void BlankOrMissingDoesNotMatch(string query) =>
        Assert.False(PlayerSearch.Matches("Alice Moon", query));
}
