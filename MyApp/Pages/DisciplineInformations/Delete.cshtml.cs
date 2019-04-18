using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.DisciplineInformations
{
    public class DeleteModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public DeleteModel(MyApp.Models.MyAppContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DisciplineInformation = await _context.DisciplineInformation.FindAsync(id);

            if (DisciplineInformation != null)
            {
                _context.DisciplineInformation.Remove(DisciplineInformation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
