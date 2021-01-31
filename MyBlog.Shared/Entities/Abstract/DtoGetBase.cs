﻿using MyBlog.Shared.Utilities.Results.ComplexTypes;

namespace MyBlog.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }
    }
}