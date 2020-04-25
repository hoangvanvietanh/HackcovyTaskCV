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
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using Hackcovy.Services;
using Hackcovy.Model;

namespace Hackcovy.View
{
    public partial class FormCreateUser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormCreateUser()
        {
            InitializeComponent();
        }
        
        public static Image Base64ToImage(string base64Image)
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64Image)))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserServices userServices = new UserServices();
            User user = new User();
            user.email = txtEmail.Text;
            user.fullName = txtFullName.Text;
            user.address = txtAddress.Text;
            user.gender = cbGender.Text;
            user.phoneNumber = txtPhoneNumber.Text;
            user.yearOfBirth = txtYear.Text;
            user.pictureProfile = "Chưa cập nhật";
            userServices.createUser(user);
            this.Close();
            Home home = new Home();
            home.ShowDialog();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
