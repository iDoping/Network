using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.StudentsInfo
{
    public class EditModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public EditModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StudentInfo StudentInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StudentInfo = await _context.StudentInfo.FirstOrDefaultAsync(m => m.ID == id);

            if (StudentInfo == null)
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

            _context.Attach(StudentInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentInfoExists(StudentInfo.ID))
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

        private bool StudentInfoExists(int id)
        {
            return _context.StudentInfo.Any(e => e.ID == id);
        }
    }
}
