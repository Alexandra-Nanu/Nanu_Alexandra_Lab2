using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nanu_Alexandra_Lab2.Data;
using Nanu_Alexandra_Lab2.Models;

namespace Nanu_Alexandra_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Nanu_Alexandra_Lab2.Data.Nanu_Alexandra_Lab2Context _context;

        public IndexModel(Nanu_Alexandra_Lab2.Data.Nanu_Alexandra_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
