using BackTaskSqlTag.DAL;
using BackTaskSqlTag.Models;
using BackTaskSqlTag.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackTaskSqlTag.Controllers
{
    public class BlogController:Controller
    {
        private readonly AppDbContext context;

        public BlogController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Blog> blogs = this.context.Blogs.Include(b=>b.Comments).ToList();
            return View(blogs);
        }

        public IActionResult Detail(int id)
        {
            //return Content(id.ToString());
            if (id == null) return NotFound();


            BlogVM model = new BlogVM
            {
                Blog = this.context.Blogs.Include(b => b.Comments).FirstOrDefault(b => b.Id == id),
                Blogs = this.context.Blogs.OrderByDescending(b=>b.Date).Take(4).ToList()
            };
            if (model.Blog == null) return NotFound();
            return View(model);
        }
    }
}
