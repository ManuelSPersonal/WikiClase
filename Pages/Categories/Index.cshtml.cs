using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WikiClase.Data;
using WikiClase.Models;

namespace WikiClase.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly WikiClase.Data.ApplicationDbContext _context;

        public IndexModel(WikiClase.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Category> CategoryList { get;set; } = default!;

        public IList<Tag> TagList { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categories != null)
                CategoryList = await _context.Categories.ToListAsync();

            if (_context.Tags != null)
                TagList = await _context.Tags.ToListAsync();
        }
    }
}
