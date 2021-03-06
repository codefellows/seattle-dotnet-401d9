﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSCohort9.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMSCohort9.Controllers
{
    public class HomeController : Controller
    {
        private IEmailSender _email;

        public HomeController(IEmailSender email)
        {
            _email = email; 
        }
        public IActionResult Index()
        {
            Email newEmail = ConstructEmail();

            _email.SendEmailAsync(newEmail.ToEmail, newEmail.Subject, newEmail.Message);

            return View();
        }

        private Email ConstructEmail()
        {
            StringBuilder sb = new StringBuilder();

            Email email = new Email();
            email.ToEmail = "amanda@codefellows.com";
            email.Subject = "Welcome to the Site";

            sb.Append("This is my message");
            sb.Append("here are the things you purchased");
            for (int i = 0; i < 10; i++)
            {
                sb.Append($"`the is item {i}`");
            }
            email.Message = sb.ToString();

            return email;
        }

        [Authorize]
        public IActionResult Cat()
        {
            return View();
        }
    }
}