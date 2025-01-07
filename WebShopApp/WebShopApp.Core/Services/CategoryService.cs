﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebShopApp.Core.Contracts;
using WebShopApp.Data;
using WebShopApp.Infrastrucutre.Data.Domain;

namespace WebShopApp.Core.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }
        public List<Category> GetCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }
        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _context.Products
                .Where(x => x.CategoryId == categoryId).ToList();
        }
    }
}
