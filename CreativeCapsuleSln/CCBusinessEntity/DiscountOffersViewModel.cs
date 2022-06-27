using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CCBusinessEntity
{
  public class DiscountOffersViewModel
    {
        public int OfferCode { get; set; }
        [Required(ErrorMessage = "Please Enter Offer Name")]
        public string OfferName { get; set; }
        [Required(ErrorMessage = "Please Select Type")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Please Enter Discount Percent")]
        public string DiscountPercent { get; set; }
        [Required(ErrorMessage = "Please Applicable From")]
        public string ApplicableFrom { get; set; }
        [Required(ErrorMessage = "Please Applicable To")]
        public string ApplicableTo { get; set; }

        public string ExMsg { get; set; }

        public string Mode { get; set; }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Double Rate { get; set; }

        public ProductViewModel ObjProduct = new ProductViewModel();
    }
}
