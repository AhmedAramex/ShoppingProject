namespace CleanArchitectureCQRs.Domain.Common;

public class Result<T>
{
    public bool Succeed { get; internal set; }
    public List<Error> Errors { get; internal set; } = new List<Error>();
    public T? Value { get; internal set; } = default;
    public ErrorType ErrorType { get; internal set; }

    public static Result<T> Success(T? value)
    {
        Result<T> res = new()
        {
            Value = value,
            Succeed = true
        };

        return res;
    }

    public static Result<T> Success()
    {
        Result<T> res = new()
        {
            Succeed = true
        };

        return res;
    }

    public static Result<T> Error(List<Error> errors, ErrorType errorType = ErrorType.Validation)
    {
        Result<T> res = new()
        {
            Succeed = false,
            Errors = errors,
            ErrorType = errorType
        };

        return res;
    }
}

public class Result
{
    public bool Succeed { get; internal set; }
    public List<Error> Errors { get; internal set; } = new List<Error>();
    public ErrorType ErrorType { get; internal set; }

    public static Result Success()
    {
        Result res = new()
        {
            Succeed = true
        };

        return res;
    }

    public static Result Error(List<Error> errors, ErrorType errorType = ErrorType.Validation)
    {
        Result res = new()
        {
            Succeed = false,
            Errors = errors,
            ErrorType = errorType
        };

        return res;
    }
}