using Staj1.Models.Abstract;
using Staj1.Models.Concrete;

namespace SampleApplication.Models.Concrete
{
    public class MockPieRepository : IPieRepository

    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId =1 ,Name="Strawberry Pie",Price=15.95M,
                ShortDescription="Lorem Ipsum",LongDescription="ndsbdsnmönbbdnfmsjnmdhsfnmd nnmfnmbm",
                Category=_categoryRepository.AllCategories.ToList()[0],ImageUrl="https://",InStock=true,
                IsPieOfTheWeek=false,ImageThumbnailUrl="sndfnsn"
                },
            };
        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return AllPies.Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId) => AllPies.FirstOrDefault(p=>p.PieId == pieId);
        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
