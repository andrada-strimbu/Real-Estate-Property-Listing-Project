﻿namespace Real_estate.Domain.Common
{
    public class Result<T> where T : class
    {
        public Result(bool isSuccess, T value, string error)
        {
            IsSuccess = isSuccess;
            Value = value;
            Error = error;
        }

        public bool IsSuccess { get; set; }
        public T Value { get; }
        public string Error { get; }
       

        public static Result<T> Success(T valeu)
        {
            return new Result<T>(true, valeu, null!);
        }
        public static Result<T> Failure(string error)
        {
            return new Result<T>(false, null!, error);
        }
    }
}

