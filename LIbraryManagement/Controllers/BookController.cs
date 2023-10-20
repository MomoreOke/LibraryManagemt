using LIbraryManagement.Data;
using LIbraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LIbraryManagement.Controllers
{
    public class BookController : Controller
    {
        ApplicationDbContext _ctx;
        public BookController(ApplicationDbContext ctx) 
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            List<Book> books = _ctx.Books.ToList();
            return View(books);
        }

        public IActionResult Add() 
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book) 
        {
            _ctx.Books.Add(book);
            _ctx.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id) 
        {
            Book book = _ctx.Books.Find(id);
            _ctx.Books.Remove(book);
            _ctx.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
