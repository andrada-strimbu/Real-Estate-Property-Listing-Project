namespace Real_estate.Domain.Common
{
    public class Result<T> where T : class
    {
        public Result(bool issuccess, T value, string error)
        {
            Issuccess = issuccess;
            Value = value;
            Error = error;
        }

        public bool Issuccess { get; }
        public T Value { get; }
        public string Error { get; }
        public static Result<T> success(T value)
        {
            return new Result<T>(true, value, null!);
        }
        public static Result<T> Failure(string error)
        {
            return new Result<T>(false, null!, error);
        }
    }
}

