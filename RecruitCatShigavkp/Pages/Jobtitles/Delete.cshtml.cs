using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatShigavkp.Data;
using RecruitCatShigavkp.Models;

namespace RecruitCatShigavkp.Pages.Jobtitles
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatShigavkp.Data.RecruitCatShigavkpContext _context;

        public DeleteModel(RecruitCatShigavkp.Data.RecruitCatShigavkpContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Jobtitle Jobtitle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Jobtitle == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.Jobtitle.FirstOrDefaultAsync(m => m.jobtitleId == id);

            if (jobtitle == null)
            {
                return NotFound();
            }
            else 
            {
                Jobtitle = jobtitle;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Jobtitle == null)
            {
                return NotFound();
            }
            var jobtitle = await _context.Jobtitle.FindAsync(id);

            if (jobtitle != null)
            {
                Jobtitle = jobtitle;
                _context.Jobtitle.Remove(Jobtitle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
