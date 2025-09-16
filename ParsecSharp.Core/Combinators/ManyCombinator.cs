using System.Linq.Expressions;
using ParsecSharp.Core.Result;

namespace ParsecSharp.Core.Combinators;

public static class ManyCombinator
{
    public static PResult<string, string[]?, string?> Many(this PResult<string, string?, string?> result, Func<> combinator)
    {

    }
}
