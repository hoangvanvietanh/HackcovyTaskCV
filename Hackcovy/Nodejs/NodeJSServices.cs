using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Hackcovy.Nodejs
{
    class NodeJSServices
    {

        public void createUserOnNodejs(UserNodejs user)
        {
            //Console.WriteLine("------------------------>" + emp.Account.UserName);
            var json = new JavaScriptSerializer().Serialize(user).ToString();
            //create the constructor with post type and few data
            MyWebRequest myRequest = new MyWebRequest("https://hackcovy-service.herokuapp.com/Ma_so_Xu_ly=Them_Nguoi_dung", "POST", json.ToString());
            //show the response string on the console screen.
            Console.WriteLine(myRequest.GetResponse());
        }

        public void createReminderOnNodejs(EmailAndReminder emailAndReminder)
        {
            //Console.WriteLine("------------------------>" + emp.Account.UserName);
            var json = new JavaScriptSerializer().Serialize(emailAndReminder).ToString();
            //create the constructor with post type and few data
            MyWebRequest myRequest = new MyWebRequest("https://hackcovy-service.herokuapp.com/Ma_so_Xu_ly=Them_Thong_bao", "POST", json.ToString());
            //show the response string on the console screen.
            Console.WriteLine(myRequest.GetResponse());
        }
    }


}
