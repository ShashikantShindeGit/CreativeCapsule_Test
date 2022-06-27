using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CCBusinessEntity
{
   public class ProductViewModel
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage ="Please Enter Product Name")]
        public string ProductName { get; set; }
        public string Type { get; set; }
        public float Rate { get; set; }
    }
}
