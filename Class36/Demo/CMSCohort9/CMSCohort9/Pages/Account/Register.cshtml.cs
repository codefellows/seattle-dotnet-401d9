using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CMSCohort9.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CMSCohort9.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public IConfiguration Configuration { get; }
        [BindProperty]
        public RegisterInput Input { get; set; }


        public RegisterModel(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            Configuration = configuration;
        }


        // Gets the default information for our page
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    Claim name = new Claim("FullName", $"{Input.FirstName} {Input.LastName}");
                    // birthdate
                    Claim birthdate = new Claim(ClaimTypes.DateOfBirth, new DateTime(user.Birthdate.Year, user.Birthdate.Month, user.Birthdate.Day).ToString("u"), ClaimValueTypes.DateTime);
                   
                    Claim email = new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email);

                    List<Claim> claims = new List<Claim> { name, birthdate, email };
                    await _userManager.AddClaimsAsync(user, claims);

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    // Add the user to specific role 
                    //if(Input.Email == Configuration["adminEmail"])
                    //{

                    //}
                    if(Input.Email == "amanda@vinicio.com")
                    {
                        await _userManager.AddToRoleAsync(user, ApplicationRoles.Admin);
                    }

                    await _userManager.AddToRoleAsync(user, ApplicationRoles.Member);

                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

            }
            return Page();

        }

        public class RegisterInput
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email Address:")]
            public string Email { get; set; }
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            [DataType(DataType.Date)]
            public DateTime Birthdate { get; set; }
            [Required]
            [DataType(DataType.Password)]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long", MinimumLength = 6)]
            public string Password { get; set; }

            [Required(ErrorMessage = "This is the error")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirm Password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match")]

            public string ConfirmPassword { get; set; }
        }

    }
}