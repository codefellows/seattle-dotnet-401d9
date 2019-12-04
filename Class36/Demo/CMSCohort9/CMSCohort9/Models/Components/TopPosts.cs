using CMSCohort9.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSCohort9.Models.Components
{
  
    public class TopPosts : ViewComponent
    {
        private BlogDBContext _context;

        public TopPosts(BlogDBContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync (int number)
        {
            var posts = _context.Posts.OrderByDescending(x => x.ID)
                                       .Take(number);
            return View(posts);
            // return View("nameofThing")
        }
    }
}
