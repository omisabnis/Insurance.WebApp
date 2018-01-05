using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Model
{
    [Table("Customer")]
    public class Customer
    {
        public Customer()
        {
            this.Ords = new HashSet<Orders>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Account Number is required.")]
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public ICollection<Orders> Ords { get; set; }
    }
}
