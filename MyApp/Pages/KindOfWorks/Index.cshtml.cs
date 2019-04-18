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
    public class IndexModel : PageModel
    {
        private readonly MyApp.Models.MyAppContext _context;

        public IndexModel(MyApp.Models.MyAppContext context)
        {
            _context = context;
        }

        public IList<KindOfWork> KindOfWork { get;set; }

        public async Task OnGetAsync()
        {
            KindOfWork = await _context.KindOfWork.ToListAsync();
        }
    }
}
