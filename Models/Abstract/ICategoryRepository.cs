using Staj1.Models.Concrete;

namespace Staj1.Models.Abstract
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
