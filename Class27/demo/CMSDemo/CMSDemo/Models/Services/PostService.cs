using CMSDemo.Data;
using CMSDemo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSDemo.Models.Services
{
     /// <summary>
     /// Implementing the Interface of Post Management onto the 
     /// 3rd party service. We will register 
     /// </summary>
    public class PostService : IPostManagement
    {
        private BlogDbContext _context;

        public PostService(BlogDbContext context)
        {
            _context = context;
        }

        public async Task CreatePostAsync(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Post>> GetAllPostsAsync() => await _context.Posts.ToListAsync();

        public async Task<Post> GetPostByIdAsync(int id) => await _context.Posts.FindAsync(id);

        public async Task RemovePostAsync(int id)
        {
            var post = await GetPostByIdAsync(id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePostAsync(Post post)
        {
            _context.Posts.Update(post);
           await _context.SaveChangesAsync();
        }
    }
}
