using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class OrderItem
    {
        [Key]
        [Column(Order=0)]
        public Guid OrderID { get; set; }
        public Order Order { get; set; }
        [Key]
        [Column(Order = 1)]
        public Guid ProductID{ get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public Rating Rating { get; set; }

    }
}
