using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlobUpload.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;


namespace BlobUpload.Pages
{
    public class IndexModel : PageModel
    {
        public Blob Blob { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            Blob = new Blob(configuration);

        }

        [BindProperty]
        public IFormFile Image { get; set; }
        public async Task OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var filePath = Path.GetTempFileName();
            CloudBlobContainer blobContainer = await Blob.GetContainer("cats");

            using (var stream = System.IO.File.Create(filePath))
            {
                await Image.CopyToAsync(stream);
            }

            await Blob.UploadFile(blobContainer, "belly", filePath);
            return Page();
        }
    }
}