using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.DeskOfNews
{
    public class DetailsModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public DetailsModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        public DeskOfNew DeskOfNew { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskOfNew = await _context.DeskOfNew.FirstOrDefaultAsync(m => m.ID == id);

            if (DeskOfNew == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
