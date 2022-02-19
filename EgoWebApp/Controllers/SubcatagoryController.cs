using Microsoft.AspNetCore.Mvc;
using EgoWebApp.Models;
using EgoWebApp.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EgoWebApp.Controllers
{
    public class SubcatagoryController : Controller
    {
        public IActionResult Index()
        {
            List<ProductSubcatagory> SubCatagories = _context.Subcatagory.ToList();
            return View(SubCatagories);

        }

        private readonly InvertoyContext _context;
        public SubcatagoryController(InvertoyContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            ProductSubcatagory SubCatagories = new ProductSubcatagory();
            return View(SubCatagories);
        }

        [HttpPost]
        public IActionResult Create(ProductSubcatagory SubCatagories)
        {
            try
            {
                _context.Subcatagory.Add(SubCatagories);
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            ProductSubcatagory SubCatagories = GetProductSubcatagory(id);
            return View(SubCatagories);
        }

        public IActionResult Edit(int id)
        {
            ProductSubcatagory SubCatagories = GetProductSubcatagory(id);
            return View(SubCatagories);
        }

        [HttpPost]
        public IActionResult Edit(ProductSubcatagory SubCatagories)
        {
            try
            {
                _context.Subcatagory.Attach(SubCatagories);
                _context.Entry(SubCatagories).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            ProductSubcatagory SubCatagories = GetProductSubcatagory(id);
            return View(SubCatagories);
        }

        [HttpPost]
        public IActionResult Delete(ProductSubcatagory SubCatagories)
        {
            try
            {
                _context.Subcatagory.Attach(SubCatagories);
                _context.Entry(SubCatagories).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }


        private ProductSubcatagory GetProductSubcatagory(int id)
        {
            ProductSubcatagory SubCatagories = _context.Subcatagory.Where(c => c.Id == id).FirstOrDefault();
            return SubCatagories;
        }
    }
}
