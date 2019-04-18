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
    public class DetailsModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public DetailsModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

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
    }
}
