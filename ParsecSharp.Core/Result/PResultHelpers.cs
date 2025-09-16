namespace ParsecSharp.Core.Result;

public static class PResultHelpers
{
    public static string AsString(this PResult<string, string?, string?> result)
    {
        return result.Output ?? result.Input;
    }

    public static int AsInt(this PResult<string, string?, string?> result)
    {
        return int.Parse(result.Output ?? result.Input);
    }

    public static double AsDouble(this PResult<string, string?, string?> result)
    {
        return double.Parse(result.Output ?? result.Input);
    }

    public static bool AsBool(this PResult<string, string?, string?> result)
    {
        return bool.Parse(result.Output ?? result.Input);
    }

    public static long AsLong(this PResult<string, string?, string?> result)
    {
        return long.Parse(result.Output ?? result.Input);
    }
}
