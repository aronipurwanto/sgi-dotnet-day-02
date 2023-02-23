using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NorthwindApp.Context;
using NorthwindApp.Models;
using NuGet.Packaging;

namespace NorthwindApp.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly NorthwindApp.Context.NorthwindContext _context;

        public IndexModel(NorthwindApp.Context.NorthwindContext context)
        {
            _context = context;
        }

        public IList<CategoryModel> ListCategory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categories != null)
            {
                // query ke table category 1
                ListCategory = await _context.Categories
                    .Select(x => new CategoryModel(x))
                    .ToListAsync();
                
                // query ke table category 2
                var newCategory = await _context.CategoryTables
                    .Select(item => new CategoryModel(item))
                    .ToListAsync();
                
                ListCategory.AddRange(newCategory);
            }
        }
    }
}
