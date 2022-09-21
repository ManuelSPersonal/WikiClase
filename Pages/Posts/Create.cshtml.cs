using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WikiClase.Data;
using WikiClase.Models;
using System.Web.Helpers;

namespace WikiClase.Pages.Posts
{
    public class CreateModel : PageModel
    {
        private readonly WikiClase.Data.ApplicationDbContext _context;

        public CreateModel(WikiClase.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["Categorias"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["Etiquetas"] = new SelectList(_context.Tags, "Id", "Name");



            return Page();
        }


        [BindProperty]
        public Post Post { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Posts.Add(Post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
