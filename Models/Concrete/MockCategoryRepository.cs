using Staj1.Models.Abstract;
using Staj1.Models.Concrete;

namespace SampleApplication.Models.Concrete
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
             new List<Category>
             {
                new Category{CategoryId=1,CategoryName="Fruit pies",Description="All-fruity pies"},
                new Category {CategoryId=2,CategoryName="Cheese Cakes",Description="Cheesy All The Way"},
                new Category {CategoryId=3,CategoryName="Seasonal pies",Description="Get in the mood for a seasonal pie"}
             };

        
    }

}
