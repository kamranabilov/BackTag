using BackTaskSqlTag.DAL;
using BackTaskSqlTag.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackTaskSqlTag.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            //List<Contact> contacts1 = new List<Contact>()
            //{
            //    new Contact
            //    {
            //        Id = 1,
            //        Image = "1.jpg",
            //        Title = "The Best Business Information",
            //        Subtitle = "We're In The Business Of Helping You",
            //        Url = "https:/www.google.com",
            //        Order = 1
            //    }
            //};

            List<Contact> contacts = this.context.Contacts.ToList();
            return View(contacts);
        }
    }
}
