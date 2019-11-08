using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlaylistDemoAppD9.Data;
using PlaylistDemoAppD9.Models;

namespace PlaylistDemoAppD9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private MusicDbContext _context;

        public SongsController(MusicDbContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public async Task<IEnumerable<Song>> Get()
        {
            return await _context.Songs.ToListAsync();
        } 

        [HttpGet("{id}")]
       
        public async Task<Song> Get(int id)
        {
            return await _context.Songs.FirstOrDefaultAsync(x => x.ID == id);
        }

        //Post

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Song song)
        {
            // Maybe check if it exists already? Not required...but suggested. 

            _context.Songs.Add(song);
            await _context.SaveChangesAsync();

            return RedirectToAction("Get", new { id = song.ID });
        }

        // Put
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Song song)
        {
            if(song.ID == id)
            {
                 _context.Songs.Update(song);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Get", new { id = song.ID });
        }
        // DELETE
    }
}