using Hackcovy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackcovy.Dao
{
    interface IUserDao
    {
        User createUser(User user);
    }
}
