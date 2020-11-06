using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLayer
{
    public class VaccinesDB
    {

        public Vaccine getVaccineByName(string _name)
        {
            try
            {
                using (var context = new veterinaryDBEntities())
                {
                    return context.Vaccines.FirstOrDefault(x => x.vaccineName == _name);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public VaccinationCertificate controlVaccineForVaccineCert(int vaccineID)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    return db.VaccinationCertificates.FirstOrDefault(x => x.VaccinesID == vaccineID);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }






        #region deleteVaccine
        public MethodResponse mrVaccineDelete(int vaccineID)
        {
            MethodResponse mr = new MethodResponse();
            mr.Object = vaccineDelete(vaccineID);
            mr.ResultText = "Aşı Bilgisi Silme İşlemi Başarılı!";
            mr.Type = MethodResponse.ResponseType.Succeed;
            return mr;
        }
        public int vaccineDelete(int vaccineID)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.relationVaccineDelete(vaccineID);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        #endregion
        #region vaccineUpdate
        public MethodResponse mrvaccineUpdate(int vaccineID, string vaccineName)
        {
            try
            {
                MethodResponse mr = new MethodResponse();
                mr.Object = vaccineUpdate(vaccineID, vaccineName);
                mr.ResultText = "Aşı Güncelleme İşlemi Başarılı!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int vaccineUpdate(int vaccineID, string vaccineName)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.vaccineUpdate(vaccineID, vaccineName);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region addVaccine
        public MethodResponse mrAddVaccine(string _vacName)
        {
            try
            {
                MethodResponse mr = new MethodResponse();
                mr.Object = addVaccine(_vacName);
                mr.ResultText = "Aşı Kayıt İşlemi Başarılı!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int addVaccine(string _vacName)
        {
            try
            {
                veterinaryDBEntities context = new veterinaryDBEntities();
                context.vaccineSave(_vacName);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region listVaccine

        public List<Vaccine> getVaccine()
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    List<Vaccine> results = db.Vaccines.ToList();
                    return results;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public Vaccine getVaccineNameByID(int vaccineID)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    return db.Vaccines.FirstOrDefault(x => x.ID == vaccineID);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }




        #endregion



        public int deleteVaccine(int vaccineID)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    db.vaccineDelete(vaccineID);
                    db.SaveChanges();
                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
