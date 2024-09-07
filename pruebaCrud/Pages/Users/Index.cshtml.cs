using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pruebaCrud.Data;
using pruebaCrud.Model;

namespace pruebaCrud.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly pruebaCrud.Data.pruebaCrudContext _context;

        public IndexModel(pruebaCrud.Data.pruebaCrudContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
