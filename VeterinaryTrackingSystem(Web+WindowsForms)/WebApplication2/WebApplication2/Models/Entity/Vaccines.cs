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
    
    public partial class Vaccines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vaccines()
        {
            this.VaccinationCertificates = new HashSet<VaccinationCertificates>();
        }
    
        public int ID { get; set; }
        public string vaccineName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaccinationCertificates> VaccinationCertificates { get; set; }
    }
}