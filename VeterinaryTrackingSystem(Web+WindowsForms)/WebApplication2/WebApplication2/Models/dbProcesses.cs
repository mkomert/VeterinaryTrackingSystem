using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models.Entity;

namespace WebApplication2.Models
{
    public class dbProcesses
    {


        public List<OperationCertificates> GetOperationCertificatesbyID(int _animalID)
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


        public Operations getOperationNameByID(int operationID)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    return db.Operations.FirstOrDefault(x => x.ID == operationID);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }








        public List<VaccinationCertificates> getVaccinationInfo(int _animalID)
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

        public Vaccines getVaccineNameByID(int vaccineID)
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




        public Customers getCardIdFromPhone(string phone)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    return db.Customers.FirstOrDefault(x => x.Phone == phone);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}