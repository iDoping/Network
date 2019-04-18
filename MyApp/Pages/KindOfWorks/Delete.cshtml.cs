using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.KindOfWorks
{
    public class DeleteModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public DeleteModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public KindOfWork KindOfWork { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            KindOfWork = await _context.KindOfWork.FirstOrDefaultAsync(m => m.ID == id);

            if (KindOfWork == null)
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

            KindOfWork = await _context.KindOfWork.FindAsync(id);

            if (KindOfWork != null)
            {
                _context.KindOfWork.Remove(KindOfWork);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
