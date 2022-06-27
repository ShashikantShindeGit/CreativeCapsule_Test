using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCDataAccess.Model;
using CCBusinessEntity;
using CCBusinessLogic.Interfaces;
using System.Data.SqlClient;

namespace CCBusinessLogic.Repositoty
{
    public class OfferRepository : IBaseInterface<DiscountOffersViewModel>
    {
        #region Object Declaration
        CreativeCapsuleDBEntities CCDBEntity;
        public OfferRepository()
        {
            CCDBEntity = new CreativeCapsuleDBEntities();
        }

        public List<DiscountOffersViewModel> GetList(DiscountOffersViewModel objModel)
        {
            List<DiscountOffersViewModel> objList = new List<DiscountOffersViewModel>();
            try
            {
                if (objModel.Mode == "GetTypes")
                {
                    objList = (from t in CCDBEntity.ProductTypes
                               select new DiscountOffersViewModel()
                               {
                                   Type = t.Type
                               }).ToList();
                    return objList;
                }
                else if (objModel.Mode == "GetProductWithOffer")
                {
                    objList = (from p in CCDBEntity.Products
                               join o in CCDBEntity.DiscountOffers on p.Type equals o.Type
                               select new DiscountOffersViewModel()
                               {
                                   ProductName = p.ProductName,
                                   Type = p.Type,
                                   Rate = p.Rate??0,
                                   OfferName=o.OfferName,
                                   DiscountPercent=o.DiscountPercent,
                                   ApplicableFrom=o.ApplicableFrom,
                                   ApplicableTo=o.ApplicableTo  
                               }).ToList();
                    return objList;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception Ex)
            {
                return null; //we can retun Exception Msg here

            }

        }

        public DiscountOffersViewModel GetSingle(DiscountOffersViewModel objModel)
        {
            throw new NotImplementedException();
        }

        public int Insert(DiscountOffersViewModel objModel)
        {
            try
            {
                int i = 0;
                if (objModel.Mode == "CreateOffer")
                {
                    if (objModel != null)
                    {
                        DiscountOffer ObjDOffer = new DiscountOffer();
                        ObjDOffer.OfferName = objModel.OfferName;
                        ObjDOffer.Type = objModel.Type;

                        ObjDOffer.DiscountPercent = objModel.DiscountPercent;
                        ObjDOffer.ApplicableFrom = objModel.ApplicableFrom;
                        ObjDOffer.ApplicableTo = objModel.ApplicableTo;
                        CCDBEntity.DiscountOffers.Add(ObjDOffer);
                        i = CCDBEntity.SaveChanges();

                    }
                }
                else
                {
                    i = 0;
                }
                return i;
            }
            catch (Exception Ex)
            {

                return -1; //we can retun exception here
            }



        }

        public int Remove(DiscountOffersViewModel objModel)
        {
            throw new NotImplementedException();
        }

        public int Update(DiscountOffersViewModel objModel)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
