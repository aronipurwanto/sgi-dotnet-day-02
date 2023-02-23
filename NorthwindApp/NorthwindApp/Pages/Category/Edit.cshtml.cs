using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NorthwindApp.Context;
using NorthwindApp.Entity;
using NorthwindApp.Models;

namespace NorthwindApp.Pages.Category
{
    public class EditModel : PageModel
    {
        private readonly NorthwindApp.Context.NorthwindContext _context;

        public EditModel(NorthwindApp.Context.NorthwindContext context)
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

            var entity =  await _context.Categories.FirstOrDefaultAsync(m => m.CategoryId == id);
            if (entity == null)
            {
                return NotFound();
            }
            CategoryModel = new CategoryModel(entity);
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            CategoryEntity entity = new CategoryEntity(CategoryModel);
            _context.Attach(entity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryModelExists(CategoryModel.CategoryId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CategoryModelExists(int id)
        {
          return (_context.Categories?.Any(e => e.CategoryId == id)).GetValueOrDefault();
        }
    }
}
