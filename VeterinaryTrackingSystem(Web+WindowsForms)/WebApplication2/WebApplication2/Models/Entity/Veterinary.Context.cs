﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
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
    
        public virtual DbSet<Animals> Animals { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<OperationCertificates> OperationCertificates { get; set; }
        public virtual DbSet<Operations> Operations { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VaccinationCertificates> VaccinationCertificates { get; set; }
        public virtual DbSet<Vaccines> Vaccines { get; set; }
    
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
    
        public virtual ObjectResult<GetCertificateInfo_Result> GetCertificateInfo(Nullable<int> p_animalID)
        {
            var p_animalIDParameter = p_animalID.HasValue ?
                new ObjectParameter("p_animalID", p_animalID) :
                new ObjectParameter("p_animalID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCertificateInfo_Result>("GetCertificateInfo", p_animalIDParameter);
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
    
        public virtual ObjectResult<Nullable<int>> getVaccineIDbyPatientID(Nullable<int> animalID)
        {
            var animalIDParameter = animalID.HasValue ?
                new ObjectParameter("animalID", animalID) :
                new ObjectParameter("animalID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getVaccineIDbyPatientID", animalIDParameter);
        }
    
        public virtual ObjectResult<isCardValid_Result> isCardValid(string cardID)
        {
            var cardIDParameter = cardID != null ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<isCardValid_Result>("isCardValid", cardIDParameter);
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
    
        public virtual int relationVaccineDelete(Nullable<int> vacID)
        {
            var vacIDParameter = vacID.HasValue ?
                new ObjectParameter("vacID", vacID) :
                new ObjectParameter("vacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("relationVaccineDelete", vacIDParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_GetAnimalIDWithCustomerID(Nullable<int> customerID)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_GetAnimalIDWithCustomerID", customerIDParameter);
        }
    
        public virtual ObjectResult<string> sp_getAnimalNameAndIDWithCardID(string cardID)
        {
            var cardIDParameter = cardID != null ?
                new ObjectParameter("CardID", cardID) :
                new ObjectParameter("CardID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_getAnimalNameAndIDWithCardID", cardIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_getCustomerIDByCardID(string cardID)
        {
            var cardIDParameter = cardID != null ?
                new ObjectParameter("CardID", cardID) :
                new ObjectParameter("CardID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_getCustomerIDByCardID", cardIDParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
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
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
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
    
        public virtual int delete_Patient(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_Patient", idParameter);
        }
    
        public virtual int deleteCustomer(string cardID)
        {
            var cardIDParameter = cardID != null ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteCustomer", cardIDParameter);
        }
    
        public virtual int deleteOperationCertByID(Nullable<int> opCertID)
        {
            var opCertIDParameter = opCertID.HasValue ?
                new ObjectParameter("opCertID", opCertID) :
                new ObjectParameter("opCertID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteOperationCertByID", opCertIDParameter);
        }
    
        public virtual int deleteVaccineCertByID(Nullable<int> certID)
        {
            var certIDParameter = certID.HasValue ?
                new ObjectParameter("certID", certID) :
                new ObjectParameter("certID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteVaccineCertByID", certIDParameter);
        }
    
        public virtual ObjectResult<string> GetCustomerName(string cardID)
        {
            var cardIDParameter = cardID != null ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetCustomerName", cardIDParameter);
        }
    
        public virtual ObjectResult<GetUserNamePW_Result> GetUserNamePW()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserNamePW_Result>("GetUserNamePW");
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
    
        public virtual int vacCertificateDelete(Nullable<int> animalID)
        {
            var animalIDParameter = animalID.HasValue ?
                new ObjectParameter("animalID", animalID) :
                new ObjectParameter("animalID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vacCertificateDelete", animalIDParameter);
        }
    
        public virtual int vaccineDelete(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vaccineDelete", iDParameter);
        }
    
        public virtual int vaccineSave(string vaccineName)
        {
            var vaccineNameParameter = vaccineName != null ?
                new ObjectParameter("vaccineName", vaccineName) :
                new ObjectParameter("vaccineName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("vaccineSave", vaccineNameParameter);
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
    
        public virtual ObjectResult<getanimalIDandNamewithCardID_Result> getanimalIDandNamewithCardID(string p_cardID)
        {
            var p_cardIDParameter = p_cardID != null ?
                new ObjectParameter("p_cardID", p_cardID) :
                new ObjectParameter("p_cardID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getanimalIDandNamewithCardID_Result>("getanimalIDandNamewithCardID", p_cardIDParameter);
        }
    }
}
