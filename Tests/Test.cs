namespace Tests;
using StrykerGeneratedRegexBug;

public class Test
{
    [Fact]
    public void SampleRegex_ShouldWork()
    {
        var obj = new ClassWithGeneratedRegex();
        Assert.Matches(obj.SampleRegex(), "a");
    }
}