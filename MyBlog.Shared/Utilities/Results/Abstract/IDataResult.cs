namespace MyBlog.Shared.Utilities.Results.Abstract
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; } // new DataResult<Category> (ResultStatus.Success, category);
                        // new DataResult<Ilist<Category>>(ResultStatus.Success, categoryList);
    }
}