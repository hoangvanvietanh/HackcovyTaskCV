using Hackcovy.Dao;
using Hackcovy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackcovy.DaoImpl
{
    class UserDaoImpl : IUserDao
    {
        private LinQDataContext db;
        private List<User> users;

        public UserDaoImpl()
        {
            db = new LinQDataContext();
            using (db)
            {
                var user = from x in db.Users select x;
                users = user.ToList();
            }
        }
        public User createUser(User user)
        {
            db = new LinQDataContext();
            User us = new User();
            us = user;
            db.Users.InsertOnSubmit(us);
            db.SubmitChanges();
            return us;
        }


        
    }
}
