using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatShigavkp.Data;
using RecruitCatShigavkp.Models;

namespace RecruitCatShigavkp.Pages.Jobtitles
{
    public class EditModel : PageModel
    {
        private readonly RecruitCatShigavkp.Data.RecruitCatShigavkpContext _context;

        public EditModel(RecruitCatShigavkp.Data.RecruitCatShigavkpContext context)
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

            var jobtitle =  await _context.Jobtitle.FirstOrDefaultAsync(m => m.jobtitleId == id);
            if (jobtitle == null)
            {
                return NotFound();
            }
            Jobtitle = jobtitle;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Jobtitle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobtitleExists(Jobtitle.jobtitleId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool JobtitleExists(int id)
        {
          return _context.Jobtitle.Any(e => e.jobtitleId == id);
        }
    }
}
