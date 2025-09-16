namespace ParsecSharp.Core.Result;

public class PResult<TInput, TResult, TError>
{
    // Represents the input
    public TInput Input { get; }

    // Represents the output (result of parsing, or default for failure)
    // if parsing in progress will match parser literal
    public TResult? Output { get; }

    // Represents the error (if failure, otherwise default)
    public TError? Error { get; }

    // Represents the remaining input if null there is no remaining input
    public TInput? RemainingInput { get; }

    // Indicates whether the result was successful
    public bool IsSuccess { get; }

    // Constructor for a successful result (Ok)
    public PResult(TInput input, TInput? remainingInput, TResult? output)
    {
        Input = input;
        RemainingInput = remainingInput;
        Output = output;
        Error = default;
        IsSuccess = true;
    }

    // Constructor for a failure result (Err)
    public PResult(TInput input, TError error)
    {
        Input = input;
        RemainingInput = default;
        Output = default;
        Error = error;
        IsSuccess = false;
    }

    // Helper method for success (Ok)
    public static PResult<TInput, TResult, TError> Ok(TInput input, TInput? remainingInput, TResult? output) => new(input, remainingInput, output);

    // Helper method for failure (Err)
    public static PResult<TInput, TResult, TError> Err(TInput remainingInput, TError error) => new(remainingInput, error);
}
