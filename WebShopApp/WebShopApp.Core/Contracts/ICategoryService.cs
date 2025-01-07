using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopApp.Infrastrucutre.Data.Domain;

namespace WebShopApp.Core.Contracts
{
    public interface ICategoryService
    {
        List<Category> GetCategoriess();
        Brand GetCategoryById(int cateegoryId);
        List<Product> GetProductsByCategory(int CategoryId);
    }
}
