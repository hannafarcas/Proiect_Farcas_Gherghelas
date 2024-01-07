using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Farcas_Gherghelas.Data;
using Proiect_Farcas_Gherghelas.Models;

namespace Proiect_Farcas_Gherghelas.Pages.Produse
{
    [Authorize(Roles ="Admin")]
    public class CreateModel : PageModel
    {
        private readonly Proiect_Farcas_Gherghelas.Data.Proiect_Farcas_GherghelasContext _context;

        public CreateModel(Proiect_Farcas_Gherghelas.Data.Proiect_Farcas_GherghelasContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["InchiriereID"] = new SelectList(_context.Inchiriere, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Produs Produs { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Produs == null || Produs == null)
            {
                return Page();
            }

            _context.Produs.Add(Produs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
