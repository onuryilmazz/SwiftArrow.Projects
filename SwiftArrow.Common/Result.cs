namespace SwiftArrow.Common;

public class Result
{
    internal Result()
    {
        Error = Error.None;
        IsSuccess = true;
    }

    internal Result(Error error)
    {
        Error = error;
        IsSuccess = false;
    }

    public Error Error { get; }

    public bool IsSuccess { get; }

    public bool IsFailure => !IsSuccess;

    public static implicit operator Result(Error error) => new Result(error);

    public static Result Success()
    {
        return new();
    }

    public static Result Failure(Error error)
    {
        return new(error);
    }

    public static Result<T> Success<T>(T value)
    {
        return new(value);
    }

    public static Result<T> Failure<T>(Error error)
    {
        return new(error);
    }
}