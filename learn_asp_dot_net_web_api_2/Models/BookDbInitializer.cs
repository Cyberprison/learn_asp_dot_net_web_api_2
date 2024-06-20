using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace learn_asp_dot_net_web_api_2.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "aaa", Author = "Aaa", Year = 123 });
            db.Books.Add(new Book { Name = "bbb", Author = "Bbb", Year = 222 });
            db.Books.Add(new Book { Name = "ccc", Author = "Ccc", Year = 321 });

            base.Seed(db);
        }
    }
}