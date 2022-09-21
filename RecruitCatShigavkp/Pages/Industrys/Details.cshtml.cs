using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatShigavkp.Data;
using RecruitCatShigavkp.Models;

namespace RecruitCatShigavkp.Pages.Industrys
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatShigavkp.Data.RecruitCatShigavkpContext _context;

        public DetailsModel(RecruitCatShigavkp.Data.RecruitCatShigavkpContext context)
        {
            _context = context;
        }

      public Industry Industry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Industry == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry.FirstOrDefaultAsync(m => m.industryId == id);
            if (industry == null)
            {
                return NotFound();
            }
            else 
            {
                Industry = industry;
            }
            return Page();
        }
    }
}
