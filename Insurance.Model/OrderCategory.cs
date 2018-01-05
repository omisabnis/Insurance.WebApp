using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Model
{
    public class OrderCategory
    {
        
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int OrderId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Categories { get; set; }

        [ForeignKey("OrderId")]
        public Orders Ords { get; set; }
    }
}
