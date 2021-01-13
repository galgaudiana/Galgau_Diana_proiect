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
    public class IndexModel : PageModel
    {
        private readonly Galgau_Diana_proiect.Data.Galgau_Diana_proiectContext _context;

        public IndexModel(Galgau_Diana_proiect.Data.Galgau_Diana_proiectContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}
