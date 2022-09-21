using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatShigavkp.Data;
using RecruitCatShigavkp.Models;

namespace RecruitCatShigavkp.Pages.Candidates
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
        ViewData["companyId"] = new SelectList(_context.Company, "companyId", "companyName");
        ViewData["industryId"] = new SelectList(_context.Industry, "industryId", "industryName");
        ViewData["jobtitleId"] = new SelectList(_context.Jobtitle, "jobtitleId", "titleName");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
