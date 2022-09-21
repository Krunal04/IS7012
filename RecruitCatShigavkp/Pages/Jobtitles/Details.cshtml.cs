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
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatShigavkp.Data.RecruitCatShigavkpContext _context;

        public DetailsModel(RecruitCatShigavkp.Data.RecruitCatShigavkpContext context)
        {
            _context = context;
        }

      public Jobtitle Jobtitle { get; set; }

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
    }
}
