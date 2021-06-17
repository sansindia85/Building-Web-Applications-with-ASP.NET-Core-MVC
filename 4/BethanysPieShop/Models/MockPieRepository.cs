using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies
        {
            get
            {
                return new List<Pie>
            {
                new Pie {PieId = 1, Name = "Strawberry Pie", Price = 15.95M, Category = new Category {CategoryName = "Fruit Pies"}},
                new Pie {PieId = 2, Name = "Cheese cake", Price = 18.95M, Category = new Category {CategoryName = "Cheese cakes"}},
                new Pie {PieId = 3, Name = "Rhubarb Pie", Price = 15.95M, Category = new Category {CategoryName = "Fruit pies"}},
                new Pie {PieId = 4, Name = "Pumpkin Pie", Price = 12.95M, Category = new Category {CategoryName = "Seasonal pies"}},
            };
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
