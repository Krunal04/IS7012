using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatShigavkp.Data;
using RecruitCatShigavkp.Models;

namespace RecruitCatShigavkp.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatShigavkp.Data.RecruitCatShigavkpContext _context;

        public DetailsModel(RecruitCatShigavkp.Data.RecruitCatShigavkpContext context)
        {
            _context = context;
        }

      public Candidate Candidate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Candidate == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate.FirstOrDefaultAsync(m => m.candidateId == id);
            if (candidate == null)
            {
                return NotFound();
            }
            else 
            {
                Candidate = candidate;
            }
            return Page();
        }
    }
}
