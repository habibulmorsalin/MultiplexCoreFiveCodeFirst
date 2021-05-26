using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiplexCoreFiveCodeFirst.Models
{
    public class User
    {
        public User()
        {
            CreateDate = DateTime.Now;
        }

        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; } 
        public string Username { get; set; } 
        public string Password { get; set; }  
    }
}
