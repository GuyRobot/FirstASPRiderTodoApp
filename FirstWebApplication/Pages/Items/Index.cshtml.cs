using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstWebApplication.Data;
using FirstWebApplication.Models;

namespace FirstWebApplication.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly FirstWebApplication.Data.ItemsContext _context;

        public IndexModel(FirstWebApplication.Data.ItemsContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Items.ToListAsync();
        }
    }
}
