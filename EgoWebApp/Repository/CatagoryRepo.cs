using EgoWebApp.Data;
using EgoWebApp.Interfaces;
using EgoWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EgoWebApp.Repository
{
    public class CatagoryRepo : ICatagory
    {
        private readonly InvertoyContext _context;

        public CatagoryRepo(InvertoyContext context)
        {
            _context = context;
        }

        public ProductCatagory Create(ProductCatagory catagories)
        {
            _context.Catagory.Add(catagories);
            _context.SaveChanges();
            return catagories;
        }

        public ProductCatagory Delete(ProductCatagory catagories)
        {
            _context.Catagory.Attach(catagories);
            _context.Entry(catagories).State = EntityState.Deleted;
            _context.SaveChanges();
            return catagories;
        }

        public ProductCatagory Edit(ProductCatagory catagories)
        {
            _context.Catagory.Attach(catagories);
            _context.Entry(catagories).State = EntityState.Modified;
            _context.SaveChanges();
            return catagories;
        }

        public List<ProductCatagory> GetItems()
        {
            List<ProductCatagory> catagories = _context.Catagory.ToList();
            return catagories;
        }

        public ProductCatagory GetProductCatagory(int id)
        {
            ProductCatagory catagory = _context.Catagory.Where(c => c.Id == id).FirstOrDefault();
            return catagory;
        }

    }
}
