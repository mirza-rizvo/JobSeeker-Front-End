using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobSeeker.Data;
using JobSeeker.Models;

namespace JobSeeker.Pages.Oglas
{
    public class EditModel : PageModel
    {
        private readonly JobSeeker.Data.ApplicationDbContext _context;

        public EditModel(JobSeeker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OglasModel OglasModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OglasModel = await _context.OglasModel.FirstOrDefaultAsync(m => m.ID == id);

            if (OglasModel == null)
            {
                return NotFound();
            }
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

            _context.Attach(OglasModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OglasModelExists(OglasModel.ID))
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

        private bool OglasModelExists(int id)
        {
            return _context.OglasModel.Any(e => e.ID == id);
        }
    }
}
