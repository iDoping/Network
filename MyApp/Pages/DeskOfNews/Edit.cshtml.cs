using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.DeskOfNews
{
    public class EditModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public EditModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DeskOfNew DeskOfNew { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskOfNew = await _context.DeskOfNew.FirstOrDefaultAsync(m => m.ID == id);

            if (DeskOfNew == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DeskOfNew).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeskOfNewExists(DeskOfNew.ID))
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

        private bool DeskOfNewExists(int id)
        {
            return _context.DeskOfNew.Any(e => e.ID == id);
        }
    }
}
