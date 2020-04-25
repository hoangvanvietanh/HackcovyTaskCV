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
using DevExpress.XtraScheduler;
using Hackcovy.View;

namespace Hackcovy
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Home()
        {
            InitializeComponent();
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hackcovyDataset.getAllUsers' table. You can move, or remove it, as needed.
            this.getAllUsersTableAdapter.Fill(this.hackcovyDataset.getAllUsers);
            // TODO: This line of code loads data into the 'hackcovyDataset.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.hackcovyDataset.Resources);
            // TODO: This line of code loads data into the 'hackcovyDataset.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.hackcovyDataset.Schedule);

            
            
        }

        private void schedulerDataStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            scheduleTableAdapter.Update(hackcovyDataset);
            hackcovyDataset.AcceptChanges();
        }

        private void gridViewUsers_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string id = gridViewUsers.Columns.View.GetFocusedRowCellValue("idUser").ToString();
            this.getPrescriptByIdUserTableAdapter.Fill(this.hackcovyDataset.getPrescriptByIdUser, Int32.Parse(id));
            gridViewUsers.ViewCaption = "Danh sách bệnh nhân \n Bạn đang chọn " + gridViewUsers.Columns.View.GetFocusedRowCellValue("fullName").ToString();
            gridViewPrescription.ViewCaption = "Danh sách đơn thuốc của " + gridViewUsers.Columns.View.GetFocusedRowCellValue("fullName").ToString();
        }

        private void gridViewPrescription_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string id = gridViewPrescription.Columns.View.GetFocusedRowCellValue("idPrescription").ToString();
            this.getDrugInPrescriptionTableAdapter.Fill(this.hackcovyDataset.getDrugInPrescription, Int32.Parse(id));
            
        }

        private void gridViewDrugInPrescription_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //string id = gridViewDrugInPrescription.Columns.View.GetFocusedRowCellValue("idPrescription").ToString();
            //this.getDrugInPrescriptionTableAdapter.Fill(this.hackcovyDataset.getDrugInPrescription, Int32.Parse(id));
        }

        private void btnAddUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCreateUser formCreateUser = new FormCreateUser();
            formCreateUser.ShowDialog();
        }

        private void btnCreatePrescription_Click(object sender, EventArgs e)
        {
            string id = gridViewUsers.Columns.View.GetFocusedRowCellValue("idUser").ToString();
            string email = gridViewUsers.Columns.View.GetFocusedRowCellValue("email").ToString();
            FormCreatePrescription prescription = new FormCreatePrescription(Int32.Parse(id),email);
            prescription.ShowDialog();
           
        }

        
    }
}