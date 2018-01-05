using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Model
{
    [Table("Orders")]
    public class Orders
    {

        [Display(Name = "OrderID")]
        public int Id { get; set; }

        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        public int ServiceCount { get; set; }
        public string AccountNumber { get; set; }


        [ForeignKey("CustomerId")]
        public Customer Customers { get; set; }

        public string CustomerName { get; set; }

        public ServiceType ServiceType { get; set; }
    }
    public enum ServiceType
    {
        Paramed,
        CreditCheck,
        CriminalReport
    }
}
