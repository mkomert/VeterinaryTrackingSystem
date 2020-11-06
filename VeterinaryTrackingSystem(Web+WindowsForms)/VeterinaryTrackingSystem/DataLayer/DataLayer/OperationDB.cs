using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLayer
{
    public class OperationDB
    {



        public Operation getOpNameByID(int _opID)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    return db.Operations.FirstOrDefault(x => x.ID == _opID);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public MethodResponse mrOperationDelete(int o_id)
        {
            try
            {
                MethodResponse mr = new MethodResponse();
                mr.Object = operationDelete(o_id);
                mr.ResultText = "Operasyon Silme İşlemi Başarılı!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception)
            {

                throw;
            }
        }





        public int operationDelete(int o_id)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.operationDelete(o_id);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }





        public MethodResponse mrOperationUpdate(string operationName, int o_id)
        {
            try
            {
                MethodResponse mr = new MethodResponse();
                mr.Object = operationUpdate(operationName, o_id);
                mr.ResultText = "Operasyon Güncelleme İşlemi Başarılı!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int operationUpdate(string operationName, int o_id)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.operationUpdate(operationName, o_id);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public MethodResponse mrOperationSave(string operationName)
        {
            MethodResponse mr = new MethodResponse();
            mr.Object = operationSave(operationName);
            mr.ResultText = "Operasyon Kayıt İşlemi Başarılı!";
            mr.Type = MethodResponse.ResponseType.Succeed;
            return mr;
        }



        public int operationSave(string operationName)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.operationSave(operationName);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Operation> getOperation()
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    List<Operation> results = db.Operations.ToList();
                    return results;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}
