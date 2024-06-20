using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//в чем отличие от ...+.DbContext???
using System.Data.Entity;

namespace learn_asp_dot_net_web_api_2.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}