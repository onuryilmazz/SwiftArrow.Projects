namespace SwiftArrow.Common;

public sealed class Result<T> : Result
{
    internal Result(T value) : base()
    {
        Value = value;
    }

    internal Result(Error error) : base(error)
    {
    }

    public T? Value { get; }

    public static implicit operator Result<T>(T value) => new Result<T>(value);

    public static implicit operator Result<T>(Error error) => new Result<T>(error);
}
