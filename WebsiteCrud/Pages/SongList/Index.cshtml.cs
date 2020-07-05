using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebsiteCrud.Model;

namespace WebsiteCrud
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Song> Songs { get; set; }

        public async Task OnGet()
        {
            Songs = await _db.Song.ToListAsync();
        }
    }
}