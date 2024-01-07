using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Farcas_Gherghelas.Data;
using Proiect_Farcas_Gherghelas.Models;

namespace Proiect_Farcas_Gherghelas.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Farcas_Gherghelas.Data.Proiect_Farcas_GherghelasContext _context;

        public DetailsModel(Proiect_Farcas_Gherghelas.Data.Proiect_Farcas_GherghelasContext context)
        {
            _context = context;
        }

      public User User { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }
            else 
            {
                User = user;
            }
            return Page();
        }
    }
}
