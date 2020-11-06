using Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLayer
{
    public class CertificateDB
    {




        public MethodResponse mrdeleteOpCertByID(int opC_id)
        {
            MethodResponse mr = new MethodResponse();
            try
            {
                mr.Object = deleteOpCertByID(opC_id);
                mr.ResultText = "Karneden Operasyon Silme İşlemi Başarılı!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception esc)
            {

                mr.Object = esc.Message;
                return mr;
            }
        }



        public int deleteOpCertByID(int opC_id)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.deleteOperationCertByID(opC_id);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }   
        }






        public MethodResponse mrDeleteVaccineCertByID(int c_id)
        {
            MethodResponse mr = new MethodResponse();
            try
            {
                
                mr.Object = deleteVaccineCertByID(c_id);
                mr.ResultText = "Karneden Aşı Silme İşlemi Başarılı!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr; 
            }
            catch (Exception esc)
            {
                mr.Object = esc.Message;
                return mr;
            }
        }




        public int deleteVaccineCertByID(int c_id)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.deleteVaccineCertByID(c_id);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }














        public OperationCertificate getOPCertificateDate(int _oID)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    return db.OperationCertificates.FirstOrDefault(x => x.ID == _oID);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }





        public List<OperationCertificate> getOpCertByMonth(string date, int _animalID, int _year)
        {
            try
            {
                veterinaryDBEntities db = new veterinaryDBEntities();
                SqlParameter year = new SqlParameter("@year", _year);
                SqlParameter animalID = new SqlParameter("@animalID", _animalID);
                SqlParameter month = new SqlParameter("@month", date);
                return db.Database.SqlQuery<OperationCertificate>("getOPCertificateByMonth @year,@animalID,@month", year, animalID, month).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<OperationCertificate> getOpCertByYear(int date, int _animalID)
        {
            try
            {
                veterinaryDBEntities db = new veterinaryDBEntities();
                SqlParameter year = new SqlParameter("@year", date);
                SqlParameter animalID = new SqlParameter("@animalID", _animalID);
                return db.Database.SqlQuery<OperationCertificate>("getOPCertificateByDate @year,@animalID", year, animalID).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }






        public List<VaccinationCertificate> getCertByMonth(string date, int _animalID, int _year)
        {
            try
            {
                veterinaryDBEntities db = new veterinaryDBEntities();
                SqlParameter year = new SqlParameter("@year", _year);
                SqlParameter animalID = new SqlParameter("@animalID", _animalID);
                SqlParameter month = new SqlParameter("@month", date);
                return db.Database.SqlQuery<VaccinationCertificate>("getCertificateByMonth @year,@animalID,@month", year, animalID, month).ToList();


            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<VaccinationCertificate> getCertByDate(int date, int _animalID)
        {
            try
            {
                
                veterinaryDBEntities db = new veterinaryDBEntities();
                SqlParameter year = new SqlParameter("@year", date);
                SqlParameter animalID = new SqlParameter("@animalID", _animalID);
                return db.Database.SqlQuery<VaccinationCertificate>("getCertificateByDate @year,@animalID", year, animalID).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }











       
        public VaccinationCertificate getCertificateDate(int _cID)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    return db.VaccinationCertificates.FirstOrDefault(x => x.ID == _cID);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<VaccinationCertificate> getVaccinationInfo(int _animalID)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    return db.VaccinationCertificates.Where(x => x.animalID == _animalID).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    





        public List<OperationCertificate> getOPCertificateByAnimalID(int _animalID)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    return db.OperationCertificates.Where(x => x.animalID == _animalID).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



















        public MethodResponse mrOperationCertificateSave(int animalID, int OperationID, DateTime date)
        {
            MethodResponse mr = new MethodResponse();
            mr.Object = operationCertificateSave(animalID, OperationID, date);
            mr.ResultText = "Operasyon Hastanın Karnesine Kaydedildi!";
            mr.Type = MethodResponse.ResponseType.Succeed;
            return mr;
        }







        public int operationCertificateSave(int animalID, int operationID, DateTime date)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.operationCertificateSave(animalID, operationID, date);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }





        public MethodResponse mrvacCertificationSave(int animalID, int vaccineID, DateTime date)
        {
            try
            {
                MethodResponse mr = new MethodResponse();
                mr.Object = vacCertificateSave(animalID, vaccineID, date);
                mr.ResultText = "Hasta Karnesine Aşı Kaydedildi!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public int vacCertificateSave(int animalID, int vaccineID, DateTime date)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.vacCertificateSave(animalID, vaccineID, date);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
