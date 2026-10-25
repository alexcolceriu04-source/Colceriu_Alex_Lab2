using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Colceriu_Alex_Lab2.Data;
using Colceriu_Alex_Lab2.Models;

namespace Colceriu_Alex_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Colceriu_Alex_Lab2.Data.Colceriu_Alex_Lab2Context _context;

        public IndexModel(Colceriu_Alex_Lab2.Data.Colceriu_Alex_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
