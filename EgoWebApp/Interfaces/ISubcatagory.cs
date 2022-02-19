using EgoWebApp.Models;
using System.Collections.Generic;

namespace EgoWebApp.Interfaces
{
    public interface ISubcatagory
    {
        List<ProductSubcatagory> GetItems();
        ProductSubcatagory GetProductSubcatagory(int id);

        ProductSubcatagory Create(ProductSubcatagory catagory);
        ProductSubcatagory Edit(ProductSubcatagory catagory);
        ProductSubcatagory Delete(ProductSubcatagory catagory);
    }
}
