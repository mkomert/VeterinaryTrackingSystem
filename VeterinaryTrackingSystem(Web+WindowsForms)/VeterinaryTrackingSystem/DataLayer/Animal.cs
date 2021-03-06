//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Animal
    {
        public Animal()
        {
            this.VaccinationCertificates = new HashSet<VaccinationCertificate>();
            this.OperationCertificates = new HashSet<OperationCertificate>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Kind { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> Age { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<VaccinationCertificate> VaccinationCertificates { get; set; }
        public virtual ICollection<OperationCertificate> OperationCertificates { get; set; }
    }
}
