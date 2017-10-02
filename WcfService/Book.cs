using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class Book
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public string authorName { get; set; }
        
    }
}