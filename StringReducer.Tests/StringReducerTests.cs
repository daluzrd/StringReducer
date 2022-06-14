namespace StringReducer.Tests;

public class StringReducerTests
{
    [Fact]
    public void IsInputValid_ShouldBeSuccescc()
    {
        Assert.True(StringReducer.IsInputValid("abc"));
        Assert.True(StringReducer.IsInputValid("aabc"));
        Assert.True(StringReducer.IsInputValid("cabbac"));

        Assert.False(StringReducer.IsInputValid("abcd"));
        Assert.False(StringReducer.IsInputValid("123"));
        Assert.False(StringReducer.IsInputValid("abc1"));
        Assert.False(StringReducer.IsInputValid("@#$"));
    }

    [Fact]
    public void ReplaceEquals_ShouldBeSuccess()
    {
        Assert.Equal('a', StringReducer.ReplaceEquals('b', 'c'));
        Assert.Equal('a', StringReducer.ReplaceEquals('c', 'b'));

        Assert.Equal('b', StringReducer.ReplaceEquals('a', 'c'));
        Assert.Equal('b', StringReducer.ReplaceEquals('c', 'a'));

        Assert.Equal('c', StringReducer.ReplaceEquals('a', 'b'));
        Assert.Equal('c', StringReducer.ReplaceEquals('b', 'a'));
    }

    [Fact]
    public void Reduce_ShouldBeSuccess()
    {
        Assert.Equal("a", StringReducer.Reduce("aabc"));
        Assert.Equal("cc", StringReducer.Reduce("abc"));
        Assert.Equal("cc", StringReducer.Reduce("cabbac"));
    }
}