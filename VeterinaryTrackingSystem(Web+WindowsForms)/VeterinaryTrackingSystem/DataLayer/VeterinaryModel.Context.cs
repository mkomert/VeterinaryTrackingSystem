﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class veterinaryDBEntities : DbContext
    {
        public veterinaryDBEntities()
            : base("name=veterinaryDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OperationCertificate> OperationCertificates { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VaccinationCertificate> VaccinationCertificates { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
    
        public virtual ObjectResult<GetUserNamePW_Result> GetUserNamePW()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserNamePW_Result>("GetUserNamePW");
        }
    
        public virtual ObjectResult<Nullable<int>> sp_GetAnimalIDWithCustomerID(Nullable<int> customerID)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_GetAnimalIDWithCustomerID", customerIDParameter);
        }
    
        public virtual ObjectResult<sp_getAnimalNameAndIDWithCardID_Result> sp_getAnimalNameAndIDWithCardID(string cardID)
        {
            var cardIDParameter = cardID != null ?
                new ObjectParameter("CardID", cardID) :
                new ObjectParameter("CardID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getAnimalNameAndIDWithCardID_Result>("sp_getAnimalNameAndIDWithCardID", cardIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_getCustomerIDByCardID(string cardID)
        {
            var cardIDParameter = cardID != null ?
                new ObjectParameter("CardID", cardID) :
                new ObjectParameter("CardID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_getCustomerIDByCardID", cardIDParameter);
        }
    
        public virtual int sp_saveAnimalByCustomerID(Nullable<int> customerID, string name, string breed, Nullable<int> age, string kind)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var breedParameter = breed != null ?
                new ObjectParameter("Breed", breed) :
                new ObjectParameter("Breed", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var kindParameter = kind != null ?
                new ObjectParameter("Kind", kind) :
                new ObjectParameter("Kind", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_saveAnimalByCustomerID", customerIDParameter, nameParameter, breedParameter, ageParameter, kindParameter);
        }
    
        public virtual int sp_saveCustomer(string name, string surname, string address, Nullable<bool> gender, string cardID, string phone)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("Surname", surname) :
                new ObjectParameter("Surname", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var genderParameter = gender.HasValue ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(bool));
    
            var cardIDParameter = cardID != null ?
                new ObjectParameter("CardID", cardID) :
                new ObjectParameter("CardID", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_saveCustomer", nameParameter, surnameParameter, addressParameter, genderParameter, cardIDParameter, phoneParameter);
        }
    
        public virtual ObjectResult<string> GetCustomerName(string cardID)
        {
            var cardIDParameter = cardID != null ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetCustomerName", cardIDParameter);
        }
    
        public virtual int deleteCustomer(string cardID)
        {
            var cardIDParameter = cardID != null ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteCustomer", cardIDParameter);
        }
    
        public virtual int customerUpdate(string cardID, string surname, string name, string address, Nullable<bool> gender, string phone)
        {
            var cardIDParameter = cardID != null ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("surname", surname) :
                new ObjectParameter("surname", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var genderParameter = gender.HasValue ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(bool));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("customerUpdate", cardIDParameter, surnameParameter, nameParameter, addressParameter, genderParameter, phoneParameter);
        }
    
        public virtual int deletePatientByCustomerID(Nullable<int> customerID)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("customerID", customerID) :
                new ObjectParameter("customerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deletePatientByCustomerID", customerIDParameter);
        }
    
        public virtual int updatePatientByCustomerID(Nullable<int> customerID, string name, string breed, string kind, Nullable<int> age)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("customerID", customerID) :
                new ObjectParameter("customerID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var breedParameter = breed != null ?
                new ObjectParameter("Breed", breed) :
                new ObjectParameter("Breed", typeof(string));
    
            var kindParameter = kind != null ?
                new ObjectParameter("Kind", kind) :
                new ObjectParameter("Kind", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatePatientByCustomerID", customerIDParameter, nameParameter, breedParameter, kindParameter, ageParameter);
        }
    
        public virtual int delete_Patient(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_Patient", idParameter);
        }
    
        public virtual int updatePatientByID(Nullable<int> iD, string name, string breed, string kind, Nullable<int> age)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var breedParameter = breed != null ?
                new ObjectParameter("Breed", breed) :
                new ObjectParameter("Breed", typeof(string));
    
            var kindParameter = kind != null ?
                new ObjectParameter("Kind", kind) :
                new ObjectParameter("Kind", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatePatientByID", iDParameter, nameParameter, breedParameter, kindParameter, ageParameter);
        }
    
        public virtual int vaccineSave(string vaccineName)
        {
            var vaccineNameParameter = vaccineName != null ?
                new ObjectParameter("vaccineName", vaccineName) :
                new ObjectParameter("vaccineName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vaccineSave", vaccineNameParameter);
        }
    
        public virtual int vaccineDelete(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vaccineDelete", iDParameter);
        }
    
        public virtual int vaccineUpdate(Nullable<int> iD, string vaccineName)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var vaccineNameParameter = vaccineName != null ?
                new ObjectParameter("vaccineName", vaccineName) :
                new ObjectParameter("vaccineName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vaccineUpdate", iDParameter, vaccineNameParameter);
        }
    
        public virtual int operationDelete(Nullable<int> operationID)
        {
            var operationIDParameter = operationID.HasValue ?
                new ObjectParameter("operationID", operationID) :
                new ObjectParameter("operationID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("operationDelete", operationIDParameter);
        }
    
        public virtual int operationSave(string operationName)
        {
            var operationNameParameter = operationName != null ?
                new ObjectParameter("operationName", operationName) :
                new ObjectParameter("operationName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("operationSave", operationNameParameter);
        }
    
        public virtual int operationUpdate(string operationName, Nullable<int> opID)
        {
            var operationNameParameter = operationName != null ?
                new ObjectParameter("operationName", operationName) :
                new ObjectParameter("operationName", typeof(string));
    
            var opIDParameter = opID.HasValue ?
                new ObjectParameter("opID", opID) :
                new ObjectParameter("opID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("operationUpdate", operationNameParameter, opIDParameter);
        }
    
        public virtual int vacCertificateDelete(Nullable<int> animalID)
        {
            var animalIDParameter = animalID.HasValue ?
                new ObjectParameter("animalID", animalID) :
                new ObjectParameter("animalID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vacCertificateDelete", animalIDParameter);
        }
    
        public virtual int vacCertificateSave(Nullable<int> animalID, Nullable<int> vaccinesID, Nullable<System.DateTime> date)
        {
            var animalIDParameter = animalID.HasValue ?
                new ObjectParameter("animalID", animalID) :
                new ObjectParameter("animalID", typeof(int));
    
            var vaccinesIDParameter = vaccinesID.HasValue ?
                new ObjectParameter("VaccinesID", vaccinesID) :
                new ObjectParameter("VaccinesID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vacCertificateSave", animalIDParameter, vaccinesIDParameter, dateParameter);
        }
    
        public virtual int relationVaccineDelete(Nullable<int> vacID)
        {
            var vacIDParameter = vacID.HasValue ?
                new ObjectParameter("vacID", vacID) :
                new ObjectParameter("vacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("relationVaccineDelete", vacIDParameter);
        }
    
        public virtual int operationCertificateSave(Nullable<int> patientID, Nullable<int> operationsID, Nullable<System.DateTime> date)
        {
            var patientIDParameter = patientID.HasValue ?
                new ObjectParameter("patientID", patientID) :
                new ObjectParameter("patientID", typeof(int));
    
            var operationsIDParameter = operationsID.HasValue ?
                new ObjectParameter("operationsID", operationsID) :
                new ObjectParameter("operationsID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("operationCertificateSave", patientIDParameter, operationsIDParameter, dateParameter);
        }
    
        public virtual ObjectResult<getVaccineInfo2_Result> getVaccineInfo2(Nullable<int> animalID)
        {
            var animalIDParameter = animalID.HasValue ?
                new ObjectParameter("animalID", animalID) :
                new ObjectParameter("animalID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getVaccineInfo2_Result>("getVaccineInfo2", animalIDParameter);
        }
    
        public virtual ObjectResult<string> getVaccineInfo(Nullable<int> animalID)
        {
            var animalIDParameter = animalID.HasValue ?
                new ObjectParameter("animalID", animalID) :
                new ObjectParameter("animalID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getVaccineInfo", animalIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getVaccineIDbyPatientID(Nullable<int> animalID)
        {
            var animalIDParameter = animalID.HasValue ?
                new ObjectParameter("animalID", animalID) :
                new ObjectParameter("animalID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getVaccineIDbyPatientID", animalIDParameter);
        }
    
        public virtual ObjectResult<getCertificateByDate_Result> getCertificateByDate(Nullable<int> year, Nullable<int> animalID)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var animalIDParameter = animalID.HasValue ?
                new ObjectParameter("animalID", animalID) :
                new ObjectParameter("animalID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCertificateByDate_Result>("getCertificateByDate", yearParameter, animalIDParameter);
        }
    
        public virtual ObjectResult<getCertificateByMonth_Result> getCertificateByMonth(Nullable<int> year, Nullable<int> animalID, string month)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var animalIDParameter = animalID.HasValue ?
                new ObjectParameter("animalID", animalID) :
                new ObjectParameter("animalID", typeof(int));
    
            var monthParameter = month != null ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCertificateByMonth_Result>("getCertificateByMonth", yearParameter, animalIDParameter, monthParameter);
        }
    
        public virtual ObjectResult<getOPCertificateByDate_Result> getOPCertificateByDate(Nullable<int> year, Nullable<int> animalID)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var animalIDParameter = animalID.HasValue ?
                new ObjectParameter("animalID", animalID) :
                new ObjectParameter("animalID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getOPCertificateByDate_Result>("getOPCertificateByDate", yearParameter, animalIDParameter);
        }
    
        public virtual ObjectResult<getOPCertificateByMonth_Result> getOPCertificateByMonth(Nullable<int> year, Nullable<int> animalID, string month)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var animalIDParameter = animalID.HasValue ?
                new ObjectParameter("animalID", animalID) :
                new ObjectParameter("animalID", typeof(int));
    
            var monthParameter = month != null ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getOPCertificateByMonth_Result>("getOPCertificateByMonth", yearParameter, animalIDParameter, monthParameter);
        }
    
        public virtual int deleteVaccineCertByID(Nullable<int> certID)
        {
            var certIDParameter = certID.HasValue ?
                new ObjectParameter("certID", certID) :
                new ObjectParameter("certID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteVaccineCertByID", certIDParameter);
        }
    
        public virtual int deleteOperationCertByID(Nullable<int> opCertID)
        {
            var opCertIDParameter = opCertID.HasValue ?
                new ObjectParameter("opCertID", opCertID) :
                new ObjectParameter("opCertID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteOperationCertByID", opCertIDParameter);
        }
    }
}
