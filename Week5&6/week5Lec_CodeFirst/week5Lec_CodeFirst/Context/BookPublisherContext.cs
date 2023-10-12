using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using week5Lec_CodeFirst.Models;

namespace week5Lec_CodeFirst.Context
{
    public class BookPublisherContext : DbContext
    {
        public DbSet <Publisher> Publishers { get; set; }

        public DbSet <Book> Books { get; set; }

    }
}