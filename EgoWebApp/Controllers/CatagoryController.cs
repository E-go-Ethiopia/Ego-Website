using Microsoft.AspNetCore.Mvc;
using EgoWebApp.Models;
using EgoWebApp.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EgoWebApp.Interfaces;

namespace EgoWebApp.Controllers
{
    public class CatagoryController : Controller
    {
        public IActionResult Index()
        {
            List<ProductCatagory> catagories = _catagoryRepo.GetItems();
            return View(catagories);
        }

        private readonly ICatagory _catagoryRepo;

        public CatagoryController(ICatagory catrepo)
        {
            _catagoryRepo = catrepo;
        }

        public IActionResult Create()
        {
            ProductCatagory catagories = new ProductCatagory();
            return View(catagories);
        }

        [HttpPost]
        public IActionResult Create(ProductCatagory catagories)
        {
            try
            {
                catagories = _catagoryRepo.Create(catagories);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            ProductCatagory catagory = _catagoryRepo.GetProductCatagory(id);
            return View(catagory);
        }

        public IActionResult Edit(int id)
        {
            ProductCatagory catagory = _catagoryRepo.GetProductCatagory(id);
            return View(catagory);
        }

        [HttpPost]
        public IActionResult Edit(ProductCatagory catagories)
        {
            try
            {
                catagories = _catagoryRepo.Edit(catagories);

            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            ProductCatagory catagory = _catagoryRepo.GetProductCatagory(id);
            return View(catagory);
        }

        [HttpPost]
        public IActionResult Delete(ProductCatagory catagories)
        {
            try
            {
                catagories = _catagoryRepo.Delete(catagories);

            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

    
    }
}
