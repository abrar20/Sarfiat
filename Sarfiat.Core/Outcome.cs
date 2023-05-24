using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Core
{
    public class Outcome
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
        public DateTime OutcomeDate { get; set; }
        public string? RecNo { get; set; }
        public double Amount { get; set; }
        public string? Details { get; set; }

        //Navigations
        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
        public int SupplierId { get; set; }
        public Suppliers Suppliers { get; set; }

        public int ProjectId { get; set; }
        public Projects Projects { get; set; }

    }
}
