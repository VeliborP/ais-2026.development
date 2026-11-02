using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.DAL;

namespace WebShop.BLL
{
    public class CategoryService
    {
        private WebShopDbContext _context;

        public CategoryService(WebShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public Category Get(int? id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
