using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models.Entity;

namespace WebApplication2.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<OperationCertDB> operationCerts { get; set; }
        public IEnumerable<CertificeDB> vaccineCerts { get; set; }
     
    }
}