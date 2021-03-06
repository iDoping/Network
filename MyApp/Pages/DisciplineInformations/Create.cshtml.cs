﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyApp.Models;

namespace MyApp.Pages.DisciplineInformations
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
        public DisciplineInformation DisciplineInformation { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DisciplineInformation.Add(DisciplineInformation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}