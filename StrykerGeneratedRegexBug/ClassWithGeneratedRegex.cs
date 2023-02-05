using System.Text.RegularExpressions;

namespace StrykerGeneratedRegexBug;

public partial class ClassWithGeneratedRegex
{
    [GeneratedRegex("a")]
    public partial Regex SampleRegex();
}