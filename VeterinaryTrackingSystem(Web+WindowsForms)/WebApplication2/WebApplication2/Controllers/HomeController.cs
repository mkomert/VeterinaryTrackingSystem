using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.Entity;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home


        public ActionResult Index()
        {
            return View();
        }







       
        public ActionResult Login(Customers _cardID)
        {
            veterinaryDBEntities context = new veterinaryDBEntities();

            List<animalDB> aList = new List<animalDB>();
            var customerFind = context.Customers.FirstOrDefault(x => x.CardID == _cardID.CardID);
            if (customerFind == null)
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Girdiğiniz Kod Boş Veya Geçersiz!',window.location='Index');</script>");
            }
            else
            {
                var animalFind = context.Animals.Where(x => x.CustomerID == customerFind.ID).ToList();
                foreach (var item in animalFind)
                {
                    animalDB aDB = new animalDB();
                    aDB.Adi = item.Name;
                    aDB.ID = item.ID;
                    aList.Add(aDB);

                }



                return View(aList);

            }
        }

    



        
        public ActionResult Show(int id)
        {
            List<int> certIDS = new List<int>();
            List<string> vaccineNames = new List<string>();
            List<int> OPcertIDS = new List<int>();
            List<string> OPvaccineNames = new List<string>();

            var _hm = new HomePageViewModel();
            var lstCerts =  new List<CertificeDB>();
            var lstOperates = new List<OperationCertDB>();
            dbProcesses dbProc = new dbProcesses();
            using (var db = new veterinaryDBEntities())
            {

                
                var certID = dbProc.getVaccinationInfo(id);
                var opCertID = dbProc.GetOperationCertificatesbyID(id);
                
                foreach (var item in certID)
                {
                    CertificeDB cDB = new CertificeDB();
                    certIDS.Add(item.ID);
                    var qwe = dbProc.getVaccineNameByID(Convert.ToInt32(item.VaccinesID));
                    
                    vaccineNames.Add(qwe.vaccineName);
                    cDB.Adi = qwe.vaccineName;
                    cDB.tarih = Convert.ToDateTime(item.Date).ToShortDateString();
                    lstCerts.Add(cDB);


                }
                _hm.vaccineCerts = (lstCerts);
                foreach (var item in opCertID)
                {
                    OperationCertDB oCDB = new OperationCertDB();
                    OPcertIDS.Add(item.ID);
                    var ewq = dbProc.getOperationNameByID(Convert.ToInt32(item.OperationsID));
                    OPvaccineNames.Add(ewq.operationName);
                    oCDB.Adi = ewq.operationName;
                    oCDB.tarih = Convert.ToDateTime(item.Date).ToShortDateString();
                    lstOperates.Add(oCDB);
                    
                }

                _hm.operationCerts = lstOperates;

            }
            return View(_hm);
            

        }


        


        [HttpGet]
        public ActionResult remembercardID()
        {
            return View();
        }




        
        public ActionResult rememberCardIDxD(rememberPw _rememberPw)
        {
            dbProcesses _db = new dbProcesses();
            var item = _db.getCardIdFromPhone(_rememberPw.Phone);
            if (item != null)
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential("veterinarytracking@gmail.com", "ramqgb3mo");
                MailMessage mail = new MailMessage();
                if (_rememberPw.Email.Contains("@") && _rememberPw.Email.Contains(".com")) 
                {

                
                mail.From = new MailAddress(_rememberPw.Email, "Veteriner Takip Sistemi");
                mail.To.Add(_rememberPw.Email);
                mail.Subject = "Veteriner Takip Sistemi Şifre"; mail.IsBodyHtml = true; mail.Body = "Sayın " + item.Name + " " + item.Surname + "\nVeteriner Takip Sistemi Karne Kodunuz:" + item.CardID;
                sc.Send(mail);
                
                return Content("<script language='javascript' type='text/javascript'>alert('Karne Kodunuz Mailinize Gönderildi!',window.location='Index');</script>");
                }
                else
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Lütfen Geçerli Bir EPosta Adresi Girin!',window.location='rememberCardID');</script>");
                }
            }

            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Telefon Numaranız Sistemde Mevcut Değil!',window.location='rememberCardID');</script>");
            }
            

        }















    }
}