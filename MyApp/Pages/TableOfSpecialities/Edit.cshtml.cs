using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.TableOfSpecialities
{
    public class EditModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public EditModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TableOfSpeciality TableOfSpeciality { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TableOfSpeciality = await _context.TableOfSpeciality.FirstOrDefaultAsync(m => m.ID == id);

            if (TableOfSpeciality == null)
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

            _context.Attach(TableOfSpeciality).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableOfSpecialityExists(TableOfSpeciality.ID))
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

        private bool TableOfSpecialityExists(int id)
        {
            return _context.TableOfSpeciality.Any(e => e.ID == id);
        }
    }
}
