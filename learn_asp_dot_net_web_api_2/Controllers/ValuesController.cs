using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using learn_asp_dot_net_web_api_2.Models;
using System.Data.Entity;

namespace learn_asp_dot_net_web_api_2.Controllers
{
    public class ValuesController : ApiController
    {
        BookContext bookContext = new BookContext();

        // GET api/values
        public IEnumerable<Book> GetBooks()
        {
            return bookContext.Books;
        }

        // GET api/values/id
        public Book GetBook(int id)
        {
            Book book = bookContext.Books.Find(id);
            return book;
        }

        // POST api/values
        [HttpPost]
        public void CreateBook([FromBody]Book book)
        {
            bookContext.Books.Add(book);
            bookContext.SaveChanges();
        }

        // PUT api/values/id
        [HttpPut]
        public void EditBook(int id, [FromBody]Book book)
        {
            if (id == book.Id)
            {
                bookContext.Entry(book).State = EntityState.Modified;

                bookContext.SaveChanges();
            }
        }

        // DELETE api/values/5
        [HttpDelete]
        public void DeleteBook(int id)
        {
            Book book = bookContext.Books.Find(id);
            if (book != null)
            {
                bookContext.Books.Remove(book);
                bookContext.SaveChanges();
            }
        }

        //чо?
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                bookContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
