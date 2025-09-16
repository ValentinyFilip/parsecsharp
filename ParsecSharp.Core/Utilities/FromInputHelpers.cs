using ParsecSharp.Core.Result;

namespace ParsecSharp.Core.Utilities;

public static class FromInputHelpers
{
    public static PResult<string, string?, string?> FromInput(this string input)
    {
        return PResult<string, string?, string?>.Ok(input: input, remainingInput: input, output: null);
    }
}
