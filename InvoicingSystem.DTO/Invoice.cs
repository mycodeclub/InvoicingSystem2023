using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicingSystem.DTO
{
    public class Invoice
    {
        [Key]
        [Display(Name = "Unique ID")]
        public Guid ID { get; set; }

        [Display(Name = "Invoice Id")]
        public int InvoiceNumber { get; set; }

        public List<InvoiceItems> items { get; set; }

//        public Customer Customer { get; set; }
        public double GrandTotal
        {
            get
            {

                if (items != null && items.Count > 0)
                    return items.Sum(i => i.Total);
                else return 0;


            }
        }
    }
}
