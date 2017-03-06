using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tutorials.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public Guid userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string streetAddress1 { get; set; }
        public string streetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}