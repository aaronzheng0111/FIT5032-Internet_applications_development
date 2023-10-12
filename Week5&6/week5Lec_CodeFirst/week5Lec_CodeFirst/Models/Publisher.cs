using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week5Lec_CodeFirst.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        public string PubName { get; set; }

        public List<Book> Books { get; set; }
    }
}