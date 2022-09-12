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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatShigavkp.Data.RecruitCatShigavkpContext _context;

        public IndexModel(RecruitCatShigavkp.Data.RecruitCatShigavkpContext context)
        {
            _context = context;
        }

        public IList<Jobtitle> Jobtitle { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Jobtitle != null)
            {
                Jobtitle = await _context.Jobtitle.ToListAsync();
            }
        }
    }
}
