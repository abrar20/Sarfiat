using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Core
{
    public class Income
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CustomerName { get; set; }
        public DateTime IncomeDate { get; set; }
        public string? RecNo { get; set; }
        public double Amount { get; set; }
        public string? Details { get; set; }

        //Navigations
        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
        public int CustomerId { get; set; }
        public Customers Customers { get; set; }

        public int ProjectId { get; set; }
        public Projects Projects { get; set; }

    }
}
