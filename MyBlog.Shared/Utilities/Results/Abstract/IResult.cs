using MyBlog.Shared.Utilities.Results.ComplexTypes;
using System;

namespace MyBlog.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public Exception Exception { get; }
    }
}