using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebsiteCrud.Model;
using Microsoft.Extensions.Logging;

namespace WebsiteCrud
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Song Song { get; set; }
        public async Task OnGet(int id)
        {
            Song = await _db.Song.FindAsync(id);

        }

        //This is a post handler for the edit page. Return type Iactionresult is used because the redirecting  of page is done here. 
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var SongFromDb = await _db.Song.FindAsync(Song.Id);
                SongFromDb.Title = Song.Title;
                SongFromDb.Artist = Song.Artist;
                SongFromDb.Lyrics = Song.Lyrics;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }

    }
}