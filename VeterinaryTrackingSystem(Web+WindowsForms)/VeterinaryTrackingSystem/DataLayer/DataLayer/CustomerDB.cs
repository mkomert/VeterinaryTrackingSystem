using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace DataLayer.DataLayer
{
    public class CustomerDB
    {
        #region MRCustomerAddForWF
        public MethodResponse CustomerAddForWF(Customer _cstmr)
        {
            try
            {
                MethodResponse mr = new MethodResponse();
                mr.Object = saveCustomer(_cstmr);
                mr.ResultText = "Hasta sahibi başarı ile kaydedildi!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region MRgetCustomerIDByCardID
        public MethodResponse mrGetCustomerByCardID(string cardID)
        {
            MethodResponse mr = new MethodResponse();
            try
            {
                
                mr.Object = Get_CustomerByCardID(cardID);
                mr.ResultText = "Müşteri Bulundu!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
                
            }
            catch (Exception)
            {

                mr.Object = cardID;
                mr.ResultText = "Kart Üzerine Kayıtlı Bilgi Bulunamadı!";
                mr.Type = MethodResponse.ResponseType.Error;
            }
            return mr;
        }
        #endregion
        #region MrDeleteCustomerByCardID
        public MethodResponse deleteCustomerByCardID(string cardID)
        {
            try
            {
                MethodResponse mr = new MethodResponse();
                mr.Object = deleteCustomer(cardID);
                mr.ResultText = "Silme İşlemi Başarılı!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion


        public Customer isCustomerAlreadyExist(string cardID)
        {
            try
            {
                using (var context = new veterinaryDBEntities())
                {
                    return context.Customers.FirstOrDefault(x => x.CardID == cardID);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }







        public MethodResponse MrUpdateCustomer(string cardID, string name, string surname, string phone, bool gender, string address)
        {
            MethodResponse mr = new MethodResponse();
            veterinaryDBEntities context = new veterinaryDBEntities();
            mr.Object = context.customerUpdate(cardID, surname, name, address, gender, phone);
            context.SaveChanges();
            mr.ResultText = "Güncelleme İşlemi Başarılı!";
            mr.Type = MethodResponse.ResponseType.Succeed;
            return mr;
            
        }





        public int updateCustomerByCardID(string cardID,string name,string surname,string phone,bool gender,string address)
        {
            veterinaryDBEntities context = new veterinaryDBEntities();
            context.customerUpdate(cardID, surname, name, address, gender, phone);
            context.SaveChanges();
            return 1;

        }

        #region getAnimalByCustomerID
        public List<Animal> getanimalNameByCardID(int CustomerID)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    List<Animal> results = db.Animals.Where(x => x.CustomerID == CustomerID).ToList();
                    return results;
                } 
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion



        #region Get_CustomerByCardID
        public Customer Get_CustomerByCardID(string cardID)
        {
            
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    Customer cstm = db.Customers.FirstOrDefault(x => x.CardID == cardID);
                    return cstm;
                }
            }
            catch (Exception)
            {

                throw;
                
            }
           
            
        }
        #endregion

        #region SaveCustomer
        public Customer saveCustomer(Customer _customer)
        {
            try
            {
                veterinaryDBEntities dbContext = new veterinaryDBEntities();
                dbContext.sp_saveCustomer(_customer.Name, _customer.Surname, _customer.Address,
                _customer.Gender, _customer.CardID, _customer.Phone);
                dbContext.SaveChanges();
                return _customer;
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion

        #region CustomerDelete
        public int deleteCustomer(string cardID)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.deleteCustomer(cardID);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        #endregion

    }
}
