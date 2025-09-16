using FluentAssertions;
using ParsecSharp.Core.Parsers;
using ParsecSharp.Core.Result;
using ParsecSharp.Core.Utilities;

namespace ParsecSharp.Tests.ParserTest;

public class ParserTests
{
    [Fact]
    public void HexColor()
    {
        const string input = "#FFA07A";

        const string expected = "FFA07A";

        string result = input.FromInput().MatchLiteral("#").AsString();

        result.Should().NotBeNull();
        result.Should().Be(expected);
    }
}
