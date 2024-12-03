namespace ParsecSharp.Core.Result;

public class PResult<TInput, TResult, TError>
{
    // Represents the input
    public TInput Input { get; }

    // Represents the output (result of parsing, or default for failure)
    public TResult? Output { get; }

    // Represents the error (if failure, otherwise default)
    public TError? Error { get; }

    // Indicates whether the result was successful
    public bool IsSuccess { get; }

    // Constructor for a successful result (Ok)
    public PResult(TInput input, TResult output)
    {
        Input = input;
        Output = output;
        Error = default;
        IsSuccess = true;
    }

    // Constructor for a failure result (Err)
    public PResult(TInput input, TError error)
    {
        Input = input;
        Output = default;
        Error = error;
        IsSuccess = false;
    }

    // Helper method for success (Ok)
    public static PResult<TInput, TResult, TError> Ok(TInput input, TResult output) => new(input, output);

    // Helper method for failure (Err)
    public static PResult<TInput, TResult, TError> Err(TInput input, TError error) => new(input, error);
}