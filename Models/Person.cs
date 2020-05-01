using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT01.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
