using EgoWebApp.Models;
using System.Collections.Generic;

namespace EgoWebApp.Interfaces
{
    public interface ICatagory
    {
        List<ProductCatagory> GetItems();
        ProductCatagory GetProductCatagory(int id);

        ProductCatagory Create(ProductCatagory catagory);
        ProductCatagory Edit(ProductCatagory catagory);
        ProductCatagory Delete(ProductCatagory catagory);
    }
}
