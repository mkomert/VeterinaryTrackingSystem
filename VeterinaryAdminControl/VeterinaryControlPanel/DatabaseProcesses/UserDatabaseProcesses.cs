using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryControlPanel.DatabaseProcesses
{
    public class UserDatabaseProcesses
    {
        public void saveUser(Users _user)
        {
            using (var db = new veterinaryDBEntities())
            {
                db.Users.Add(_user);
                db.SaveChanges();
            }
        }


        public void updateUser(Users _user)
        {
            using (var db = new veterinaryDBEntities())
            {
                var result = db.Users.SingleOrDefault(b => b.ID == _user.ID);
                if (result != null)
                {
                    result.name = _user.name;
                    result.password = _user.password;
                    db.SaveChanges();
                }
            }
        }


        public List<Users> getUsersList()
        {
            using (var db = new veterinaryDBEntities())
            {
                List<Users> listedUser = new List<Users>();
                listedUser = db.Users.ToList();
                return listedUser;
            }
        }

        public Users getUserByID(int id)
        {
            using (var db = new veterinaryDBEntities())
            {
                return db.Users.FirstOrDefault(x => x.ID == id);
            }
        }


        public void deleteUser(int userid)
        {
            using (var db = new veterinaryDBEntities())
            {
                var user = db.Users.FirstOrDefault(x => x.ID == userid);
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }


    }
}
