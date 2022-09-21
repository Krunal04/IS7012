using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatShigavkp.Data;
using RecruitCatShigavkp.Models;

namespace RecruitCatShigavkp.Pages.Jobtitles
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatShigavkp.Data.RecruitCatShigavkpContext _context;

        public CreateModel(RecruitCatShigavkp.Data.RecruitCatShigavkpContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Jobtitle Jobtitle { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Jobtitle.Add(Jobtitle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
