using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicingSystem.DTO
{
    public class InvoiceItems
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public string ItemDiscription { get; set; } = string.Empty;
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double Total
        {
            get
            {
                return (UnitPrice * Quantity);
            }
        }
    }
}
