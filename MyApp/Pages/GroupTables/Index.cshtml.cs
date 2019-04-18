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
    public class IndexModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public IndexModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        public IList<GroupTable> GroupTable { get;set; }

        public async Task OnGetAsync()
        {
            GroupTable = await _context.GroupTable.ToListAsync();
        }
    }
}
