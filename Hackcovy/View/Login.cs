using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Web.Script.Serialization;
using Hackcovy.Nodejs;
using Newtonsoft.Json;
using System.IO;
using Hackcovy.View;
namespace Hackcovy.View
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();

            
            

            //Console.WriteLine("------------------------>" + emp.Account.UserName);
            //var json = new JavaScriptSerializer().Serialize(setAddEmployee(emp)).ToString();
            //create the constructor with post type and few data
            MyWebRequest myRequest = new MyWebRequest("http://127.0.0.1:1200/Ma_so_Xu_ly=Doc_Danh_sach_Nguoi_dung", "POST");
            //show the response string on the console screen.
            String json = myRequest.GetResponse();
            Console.WriteLine(json);
            
            /*
            List<User> obj = JsonConvert.DeserializeObject<List<User>>(json);
            obj.ForEach(x =>
            {
                Console.WriteLine(x.email);
                x.listReminder.ForEach(y =>
                {
                    Console.WriteLine(y.notes);
                });
            });*/

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
        }
    }
}