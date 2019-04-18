using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.TableOfSpecialities
{
    public class DeleteModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public DeleteModel(MyApp.Models.MyAppContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TableOfSpeciality = await _context.TableOfSpeciality.FindAsync(id);

            if (TableOfSpeciality != null)
            {
                _context.TableOfSpeciality.Remove(TableOfSpeciality);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
