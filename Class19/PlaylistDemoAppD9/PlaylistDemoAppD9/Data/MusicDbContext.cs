using Microsoft.EntityFrameworkCore;
using PlaylistDemoAppD9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistDemoAppD9.Data
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }
    }
}
