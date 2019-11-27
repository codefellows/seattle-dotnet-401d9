using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CMSCohort9.Pages
{
    [Authorize]
    public class SecretPageModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}