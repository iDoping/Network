using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.DisciplineInformations
{
    public class EditModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public EditModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DisciplineInformation DisciplineInformation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DisciplineInformation = await _context.DisciplineInformation.FirstOrDefaultAsync(m => m.ID == id);

            if (DisciplineInformation == null)
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

            _context.Attach(DisciplineInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DisciplineInformationExists(DisciplineInformation.ID))
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

        private bool DisciplineInformationExists(int id)
        {
            return _context.DisciplineInformation.Any(e => e.ID == id);
        }
    }
}
