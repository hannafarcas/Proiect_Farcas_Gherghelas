﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Farcas_Gherghelas.Data;
using Proiect_Farcas_Gherghelas.Models;

namespace Proiect_Farcas_Gherghelas.Pages.Produse
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Farcas_Gherghelas.Data.Proiect_Farcas_GherghelasContext _context;

        public DetailsModel(Proiect_Farcas_Gherghelas.Data.Proiect_Farcas_GherghelasContext context)
        {
            _context = context;
        }

      public Produs Produs { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Produs == null)
            {
                return NotFound();
            }

            var produs = await _context.Produs.FirstOrDefaultAsync(m => m.ID == id);
            if (produs == null)
            {
                return NotFound();
            }
            else 
            {
                Produs = produs;
            }
            return Page();
        }
    }
}
