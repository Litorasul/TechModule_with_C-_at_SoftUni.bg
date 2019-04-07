using System;
using System.Collections.Generic;
using System.Linq;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
       
        public IActionResult Index()
        {
            using (var db = new LibraryDbContext())
            {
                List<Book> allBooks = db.Books.ToList();
                return this.View(allBooks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new LibraryDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //TO DO
            return null;
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            //TO DO
            return null;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //TO DO
            return null;
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            //TO DO
            return null;
        }
    }
}