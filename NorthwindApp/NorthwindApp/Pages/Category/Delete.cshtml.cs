using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NorthwindApp.Context;
using NorthwindApp.Entity;
using NorthwindApp.Models;

namespace NorthwindApp.Pages.Category
{
    public class DeleteModel : PageModel
    {
        private readonly NorthwindApp.Context.NorthwindContext _context;

        public DeleteModel(NorthwindApp.Context.NorthwindContext context)
        {
            _context = context;
        }

        [BindProperty]
      public CategoryModel CategoryModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var entity = await _context.Categories.FirstOrDefaultAsync(m => m.CategoryId == id);

            if (entity == null)
            {
                return NotFound();
            }
            else 
            {
                CategoryModel = new CategoryModel(entity);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }
            var entity = await _context.Categories.FindAsync(id);

            if (entity != null)
            {
                CategoryEntity oldEntity = new CategoryEntity(CategoryModel);
                _context.Categories.Remove(entity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
