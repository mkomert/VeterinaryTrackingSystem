//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Animals
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Animals()
        {
            this.VaccinationCertificates = new HashSet<VaccinationCertificates>();
            this.OperationCertificates = new HashSet<OperationCertificates>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Kind { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> Age { get; set; }
    
        public virtual Customers Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaccinationCertificates> VaccinationCertificates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationCertificates> OperationCertificates { get; set; }
    }
}
