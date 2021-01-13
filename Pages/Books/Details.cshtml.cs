using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Galgau_Diana_proiect.Data;
using Galgau_Diana_proiect.Models;

namespace Galgau_Diana_proiect.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Galgau_Diana_proiect.Data.Galgau_Diana_proiectContext _context;

        public DetailsModel(Galgau_Diana_proiect.Data.Galgau_Diana_proiectContext context)
        {
            _context = context;
        }

        public Car Car { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Car = await _context.Car.FirstOrDefaultAsync(m => m.ID == id);

            if (Car == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
