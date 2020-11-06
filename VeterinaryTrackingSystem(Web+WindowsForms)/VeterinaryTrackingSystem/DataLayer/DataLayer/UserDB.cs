using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLayer
{
    public class UserDB
    {
        public MethodResponse mrUserLogin(User _user)
        {
            MethodResponse mr = new MethodResponse();
            try
            {
                
                mr.Object = UserLogin(_user);
                mr.ResultText = "Kullanıcı Girişi Başarılı!";
                mr.Type = MethodResponse.ResponseType.Succeed;
                return mr;
            }
            catch (Exception esc)
            {
                mr.Object = _user;
                mr.ResultText = "HATA!";
                mr.Type = MethodResponse.ResponseType.Error;
                
            }
            return mr;
        }










        public User UserLogin(User _usr)
        {
            try
            {
                using (var db = new veterinaryDBEntities())
                {
                    User LoginUser = db.Users.FirstOrDefault(x => x.name == _usr.name && x.password == _usr.password);
                    return LoginUser;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
