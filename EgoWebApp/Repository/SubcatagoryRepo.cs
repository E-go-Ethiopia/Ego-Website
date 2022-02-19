using EgoWebApp.Data;
using EgoWebApp.Interfaces;
using EgoWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EgoWebApp.Repository
{
    public class SubcatagoryRepo : ISubcatagory
    {
        private readonly InvertoyContext _context;

        public SubcatagoryRepo(InvertoyContext context)
        {
            _context = context;
        }

        public ProductSubcatagory Create(ProductSubcatagory subcatagory)
        {
            _context.Subcatagory.Add(subcatagory);
            _context.SaveChanges();
            return subcatagory;
        }

        public ProductSubcatagory Delete(ProductSubcatagory subcatagory)
        {
            _context.Subcatagory.Attach(subcatagory);
            _context.Entry(subcatagory).State = EntityState.Deleted;
            _context.SaveChanges();
            return subcatagory;
        }

        public ProductSubcatagory Edit(ProductSubcatagory subcatagory)
        {
            _context.Subcatagory.Attach(subcatagory);
            _context.Entry(subcatagory).State = EntityState.Modified;
            _context.SaveChanges();
            return subcatagory;
        }

        public List<ProductSubcatagory> GetItems()
        {
            List<ProductSubcatagory> subcatagory = _context.Subcatagory.ToList();
            return subcatagory;
        }

        public ProductSubcatagory GetProductCatagory(int id)
        {
            ProductSubcatagory subcatagory = _context.Subcatagory.Where(c => c.Id == id).FirstOrDefault();
            return subcatagory;
        }

        public ProductSubcatagory GetProductSubcatagory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
