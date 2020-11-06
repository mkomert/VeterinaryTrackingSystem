using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLayer
{
    public class PatientDB
    {
        #region PatientSave
        public MethodResponse mrSavePatient(int _CustomerID, string name, string breed, int age, string kind)
        {
            try
            {
                MethodResponse mr = new MethodResponse();
                mr.Object = savePatient(_CustomerID, name, breed, kind, age);
                mr.ResultText = "Hasta Kayıt İşlemi Başarılı!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        public int savePatient(int _CustomerID, string name, string breed, string kind, int age)
        {
            veterinaryDBEntities context = new veterinaryDBEntities();
            context.sp_saveAnimalByCustomerID(_CustomerID, name, breed, age, kind);
            context.SaveChanges();
            return 1;
        }
        #endregion
        #region PatientDelete


        public MethodResponse mrdeletePatient(int _patientID)
        {
            try
            {
                MethodResponse mr = new MethodResponse();
                mr.Object = deletePatient(_patientID);
                mr.ResultText = "Hasta Silme İşlemi Başarılı!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception)
            {

                throw;
            }
           

        }




        public Animal getAnimalByID(int _animalID)
        {
            try
            {
                using (var context = new veterinaryDBEntities())
                {
                    Animal _animal = context.Animals.FirstOrDefault(x => x.ID == _animalID);
                    return _animal;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }





        public int deletePatient(int _patientID)
        {
            veterinaryDBEntities context = new veterinaryDBEntities();
            context.delete_Patient(_patientID);
            context.SaveChanges();
            return 1;
        }




        #endregion
        #region PatientUpdate

        public MethodResponse mrupdatePatient(int ID, string name, string breed, string kind, int age)
        {
            try
            {
                MethodResponse mr = new MethodResponse();
                mr.Object = updatePatient(ID, name, breed, kind, age);
                mr.ResultText = "Hasta Güncelleme Başarılı!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int updatePatient(int ID, string name, string breed, string kind, int age)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.updatePatientByID(ID, name, breed, kind, age);
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
