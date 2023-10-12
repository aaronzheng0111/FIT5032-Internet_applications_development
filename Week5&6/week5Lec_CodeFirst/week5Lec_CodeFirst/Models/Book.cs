using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week5Lec_CodeFirst.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string BookName { get; set; }

        public string Author { get; set; }
        public int PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}