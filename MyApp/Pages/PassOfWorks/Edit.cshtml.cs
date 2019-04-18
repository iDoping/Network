using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.PassOfWorks
{
    public class EditModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public EditModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PassOfWork PassOfWork { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PassOfWork = await _context.PassOfWork.FirstOrDefaultAsync(m => m.ID == id);

            if (PassOfWork == null)
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

            _context.Attach(PassOfWork).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassOfWorkExists(PassOfWork.ID))
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

        private bool PassOfWorkExists(int id)
        {
            return _context.PassOfWork.Any(e => e.ID == id);
        }
    }
}
