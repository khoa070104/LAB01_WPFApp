using System.Collections.Generic;
using BusinessObjects;

using System.Collections.Generic;
using BusinessObjects;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            Category beverages = new Category(1, "Beverages");
            Category condiments = new Category(2, "Condiments");
            Category confections = new Category(3, "Confections");
            Category dairy = new Category(4, "Dairy Products");
            Category grains = new Category(5, "Grains/Cereals");
            Category meat = new Category(6, "Meat/Poultry");
            Category produce = new Category(7, "Produce");
            Category seafood = new Category(8, "Seafood");

            var listCategories = new List<Category>();
            try
            {
                listCategories.Add(beverages);
                listCategories.Add(condiments);
                listCategories.Add(confections);
                listCategories.Add(dairy);
                listCategories.Add(grains);
                listCategories.Add(meat);
                listCategories.Add(produce);
                listCategories.Add(seafood);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listCategories;
        }
    }
}
