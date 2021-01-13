using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Galgau_Diana_proiect.Data;
using Galgau_Diana_proiect.Models;

namespace Galgau_Diana_proiect.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Galgau_Diana_proiect.Data.Galgau_Diana_proiectContext _context;

        public CreateModel(Galgau_Diana_proiect.Data.Galgau_Diana_proiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Car Car { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Car.Add(Car);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
