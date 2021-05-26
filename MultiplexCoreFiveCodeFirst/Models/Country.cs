using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiplexCoreFiveCodeFirst.Models
{
    public class Country
    {
        public Country()
        {
            CreateDate = DateTime.Now;
        }

        public long Id { get; set; } 
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
