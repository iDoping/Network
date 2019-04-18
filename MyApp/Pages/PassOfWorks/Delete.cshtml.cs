using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.PassOfWorks
{
    public class DeleteModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public DeleteModel(MyApp.Models.MyAppContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PassOfWork = await _context.PassOfWork.FindAsync(id);

            if (PassOfWork != null)
            {
                _context.PassOfWork.Remove(PassOfWork);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
