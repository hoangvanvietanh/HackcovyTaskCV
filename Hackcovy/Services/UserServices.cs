using Hackcovy.Dao;
using Hackcovy.DaoImpl;
using Hackcovy.Model;
using Hackcovy.Nodejs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackcovy.Services
{
    class UserServices
    {
        IUserDao userDao = new UserDaoImpl();
        NodeJSServices nodeJS = new NodeJSServices();

        public void createUser(User user)
        {
            UserNodejs userNodejs = new UserNodejs();
            userNodejs.Address = user.address;
            userNodejs.FullName = user.fullName;
            userNodejs.Email = user.email;
            userNodejs.Gender = user.gender;
            userNodejs.PhoneNumber = user.phoneNumber;
            userNodejs.YearOfBirth = user.yearOfBirth;
            userNodejs.PictureProfile = "Chưa cập nhật";
            userNodejs.ListReminder = new List<PrescriptionNodejs>();

            nodeJS.createUserOnNodejs(userNodejs);
            userDao.createUser(user);
        }

       
    }
}
