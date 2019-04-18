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
    public class IndexModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public IndexModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        public IList<DisciplineInformation> DisciplineInformation { get;set; }

        public async Task OnGetAsync()
        {
            DisciplineInformation = await _context.DisciplineInformation.ToListAsync();
        }
    }
}
