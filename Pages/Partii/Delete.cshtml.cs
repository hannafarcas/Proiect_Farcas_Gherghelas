using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Farcas_Gherghelas.Data;
using Proiect_Farcas_Gherghelas.Models;

namespace Proiect_Farcas_Gherghelas.Pages.Partii
{
    [Authorize(Roles = "Admin")]
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Farcas_Gherghelas.Data.Proiect_Farcas_GherghelasContext _context;

        public DeleteModel(Proiect_Farcas_Gherghelas.Data.Proiect_Farcas_GherghelasContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Partie Partie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Partie == null)
            {
                return NotFound();
            }

            var partie = await _context.Partie.FirstOrDefaultAsync(m => m.ID == id);

            if (partie == null)
            {
                return NotFound();
            }
            else 
            {
                Partie = partie;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Partie == null)
            {
                return NotFound();
            }
            var partie = await _context.Partie.FindAsync(id);

            if (partie != null)
            {
                Partie = partie;
                _context.Partie.Remove(Partie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
