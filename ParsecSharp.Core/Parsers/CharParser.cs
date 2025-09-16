using ParsecSharp.Core.Result;

namespace ParsecSharp.Core.Parsers;

public static class CharParser
{
    public static PResult<string, string?, string?> MatchLiteral(this PResult<string, string?, string?> input, string literal)
    {
        if (input.RemainingInput is null) return PResult<string, string?, string?>.Err(input.Input, "Input cannot be empty.");
        if (!input.RemainingInput.StartsWith(literal))
        {
            return PResult<string, string?, string?>.Err(input.Input, "Input doesnt start with '" + literal + "'.");
        }

        string? output = input.RemainingInput[literal.Length..];
        return PResult<string, string?, string?>.Ok(input.Input, output, output);
    }

    public static PResult<string, string?, string?> MatchRegex(this PResult<string, string?, string?> input,
        string regex)
    {
        if (input.RemainingInput is null) return PResult<string, string?, string?>.Err(input.Input, "Input cannot be empty.");
        if (!input.RemainingInput.StartsWith(regex))
        {
            return PResult<string, string?, string?>.Err(input.Input, "Input doesnt start with '" + regex + "'.");
        }

        string? output = input.RemainingInput[regex.Length..];
        return PResult<string, string?, string?>.Ok(input.Input, output, output);
    }
}
