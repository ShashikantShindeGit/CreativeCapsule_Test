using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CCBusinessEntity;
using CCBusinessLogic.Interfaces;
using CCBusinessLogic.Repositoty;

namespace CCWeb.Controllers
{
    public class ProductController : Controller
    {
        #region Object Declaration
        IBaseInterface<DiscountOffersViewModel> ObjOfferRepo = new OfferRepository();
        #endregion
        // GET: Product
        public ActionResult ProductList()
        {
            ViewBag.ProductList = ObjOfferRepo.GetList(new DiscountOffersViewModel() { Mode="GetProductWithOffer" });
            return View();
        }
        #region Create Discount

        [HttpGet]
        public ActionResult Discount()
        {
            try
            {
                ViewBag.Type = ObjOfferRepo.GetList(new DiscountOffersViewModel() { Mode = "GetTypes" });
                return View();
            }
            catch (Exception)
            { 
                throw; // we can manage error log here
            }
         
        }
        [HttpPost]
        public ActionResult Discount(DiscountOffersViewModel objModel)
        {
            try
            {
                if (objModel != null)
                {
                    objModel.Mode = "CreateOffer";

                    int i = ObjOfferRepo.Insert(objModel);
                    if (i > 0)
                    {
                        TempData["MsgScc"] = "Offer created successfully.";
                    }
                    else
                    {
                        TempData["MsgErr"] = "Offer not created. Please try again.";
                    }
                }
                ViewBag.Type = ObjOfferRepo.GetList(new DiscountOffersViewModel() { Mode = "GetTypes" });
                return View();
            }
            catch (Exception Ex)
            { 
                throw; // we can manage error log here
            }

        
           
        }

        #endregion

    }
}