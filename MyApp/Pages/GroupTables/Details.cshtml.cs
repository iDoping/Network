using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Pages.GroupTables
{
    public class DetailsModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public DetailsModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        public GroupTable GroupTable { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GroupTable = await _context.GroupTable.FirstOrDefaultAsync(m => m.ID == id);

            if (GroupTable == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
