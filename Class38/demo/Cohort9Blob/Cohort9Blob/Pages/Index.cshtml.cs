using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Cohort9Blob.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Cohort9Blob.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public IFormFile Image { get; set; }
        [BindProperty]
        public string Name { get; set; }
        public Blob Blob { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            Blob = new Blob(configuration);
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var filepath = Path.GetTempFileName();
            CloudBlobContainer container = await Blob.GetContainer("cats");

            using (var stream = System.IO.File.Create(filepath))
            {
                await Image.CopyToAsync(stream);
            }

            await Blob.UploadFile(container, Name, filepath);

            CloudBlob catPic = await Blob.GetBlob(Name, container.Name);
            string url = catPic.Uri.ToString();

            return Page();
        }
    }
}