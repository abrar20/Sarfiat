using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Core
{
    public class Categories
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Details { get; set; }
        public double Balance { get; set; }
        public DateTime AddedDate { get; set; }
        
        //Navigations

        public virtual List<Outcome> Outcome { get; set;}
    }
}
