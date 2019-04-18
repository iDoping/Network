using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyApp.Models;

namespace MyApp.Pages.TableOfSpecialities
{
    public class CreateModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public CreateModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TableOfSpeciality TableOfSpeciality { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TableOfSpeciality.Add(TableOfSpeciality);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}