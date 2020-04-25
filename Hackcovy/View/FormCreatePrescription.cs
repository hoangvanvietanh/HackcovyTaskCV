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
using DevExpress.XtraEditors.Filtering.Templates;

namespace Hackcovy.View
{
    public partial class FormCreatePrescription : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private PrescriptionServices prescriptionServices = new PrescriptionServices();
        private int _idUser;
        private string _emailUser;
        
        public FormCreatePrescription(int idUser, string emailUser)
        {
            _idUser = idUser;
            _emailUser = emailUser;
            InitializeComponent();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Prescription prescription = new Prescription();
            prescription.idUser = _idUser;
            prescription.notes = txtNote.Text;
            prescription.reExamination = dateTimePickerReExamination.Value.ToString();
            prescription.date = DateTime.Now.ToString();
            prescription.emailShare = "hoangvanvietanh@gmail.com";
            prescription.diagnostic = txtDiagnostic.Text;

            List<DrugInPrescription> drugInPrescriptions = new List<DrugInPrescription>();
            DrugInPrescription drugInPrescription;
            DataRowView row;
            if (txtDrugName1.EditValue.ToString().Trim() != "" && txtTime1.Text.Trim() != "" && txtDosage1.Text.Trim() != "" && txtAmountOfMedicine1.Text.Trim() != "")
            {
                drugInPrescription = new DrugInPrescription();
                drugInPrescription.amountOfMedicine = Int32.Parse(txtAmountOfMedicine1.Text) ;
                drugInPrescription.dosage = Int32.Parse(txtDosage1.Text);
                drugInPrescription.time = txtTime1.Text;
                 row = txtDrugName1.Properties.GetRowByKeyValue(txtDrugName1.EditValue) as DataRowView;
                drugInPrescription.drugName = row["drugName"].ToString();
                drugInPrescription.color = row["color"].ToString();
                drugInPrescription.image = row["image"].ToString();
                drugInPrescriptions.Add(drugInPrescription);

            }


            if (txtDrugName2.EditValue.ToString() != "" && txtTime2.Text != "" && txtDosage2.Text != "" && txtAmountOfMedicine2.Text != "")
            {
                drugInPrescription = new DrugInPrescription();
                drugInPrescription.amountOfMedicine = Int32.Parse(txtAmountOfMedicine2.Text);
                drugInPrescription.dosage = Int32.Parse(txtDosage2.Text);
                drugInPrescription.time = txtTime2.Text;
                 row = txtDrugName2.Properties.GetRowByKeyValue(txtDrugName2.EditValue) as DataRowView;
                drugInPrescription.drugName = row["drugName"].ToString();
                drugInPrescription.color = row["color"].ToString();
                drugInPrescription.image = row["image"].ToString();
                drugInPrescriptions.Add(drugInPrescription);
            }

            if (txtDrugName3.EditValue.ToString() != "" && txtTime3.Text != "" && txtDosage3.Text != "" && txtAmountOfMedicine3.Text != "")
            {
                drugInPrescription = new DrugInPrescription();
                drugInPrescription.amountOfMedicine = Int32.Parse(txtAmountOfMedicine3.Text);
                drugInPrescription.dosage = Int32.Parse(txtDosage3.Text);
                drugInPrescription.time = txtTime3.Text;
                row = txtDrugName3.Properties.GetRowByKeyValue(txtDrugName3.EditValue) as DataRowView;
                drugInPrescription.drugName = row["drugName"].ToString();
                drugInPrescription.color = row["color"].ToString();
                drugInPrescription.image = row["image"].ToString();
                drugInPrescriptions.Add(drugInPrescription);
            }

            if (txtDrugName4.EditValue.ToString() != "" && txtTime4.Text != "" && txtDosage4.Text != "" && txtAmountOfMedicine4.Text != "")
            {
                drugInPrescription = new DrugInPrescription();
                drugInPrescription.amountOfMedicine = Int32.Parse(txtAmountOfMedicine4.Text);
                drugInPrescription.dosage = Int32.Parse(txtDosage4.Text);
                drugInPrescription.time = txtTime4.Text;
                row = txtDrugName4.Properties.GetRowByKeyValue(txtDrugName4.EditValue) as DataRowView;
                drugInPrescription.drugName = row["drugName"].ToString();
                drugInPrescription.color = row["color"].ToString();
                drugInPrescription.image = row["image"].ToString();
                drugInPrescriptions.Add(drugInPrescription);
            }

            if (txtDrugName5.EditValue.ToString() != "" && txtTime5.Text != "" && txtDosage5.Text != "" && txtAmountOfMedicine5.Text != "")
            {
                drugInPrescription = new DrugInPrescription();
                drugInPrescription.amountOfMedicine = Int32.Parse(txtAmountOfMedicine5.Text);
                drugInPrescription.dosage = Int32.Parse(txtDosage5.Text);
                drugInPrescription.time = txtTime5.Text;
                row = txtDrugName5.Properties.GetRowByKeyValue(txtDrugName5.EditValue) as DataRowView;
                drugInPrescription.drugName = row["drugName"].ToString();
                drugInPrescription.color = row["color"].ToString();
                drugInPrescription.image = row["image"].ToString();
                drugInPrescriptions.Add(drugInPrescription);
            }

            if (txtDrugName6.EditValue.ToString() != "" && txtTime6.Text != "" && txtDosage6.Text != "" && txtAmountOfMedicine6.Text != "")
            {
                drugInPrescription = new DrugInPrescription();
                drugInPrescription.amountOfMedicine = Int32.Parse(txtAmountOfMedicine6.Text);
                drugInPrescription.dosage = Int32.Parse(txtDosage6.Text);
                drugInPrescription.time = txtTime6.Text;
                row = txtDrugName6.Properties.GetRowByKeyValue(txtDrugName6.EditValue) as DataRowView;
                drugInPrescription.drugName = row["drugName"].ToString();
                drugInPrescription.color = row["color"].ToString();
                drugInPrescription.image = row["image"].ToString();
                drugInPrescriptions.Add(drugInPrescription);
            }

            if (txtDrugName7.EditValue.ToString() != "" && txtTime7.Text != "" && txtDosage7.Text != "" && txtAmountOfMedicine7.Text != "")
            {
                drugInPrescription = new DrugInPrescription();
                drugInPrescription.amountOfMedicine = Int32.Parse(txtAmountOfMedicine7.Text);
                drugInPrescription.dosage = Int32.Parse(txtDosage2.Text);
                drugInPrescription.time = txtTime7.Text;
                row = txtDrugName7.Properties.GetRowByKeyValue(txtDrugName7.EditValue) as DataRowView;
                drugInPrescription.drugName = row["drugName"].ToString();
                drugInPrescription.color = row["color"].ToString();
                drugInPrescription.image = row["image"].ToString();
                drugInPrescriptions.Add(drugInPrescription);
            }
            prescriptionServices.createPrescription(prescription, drugInPrescriptions, _emailUser);
            Home home = new Home();
            this.Close();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtTime1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCreatePrescription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hackcovyDataset.Drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.hackcovyDataset.Drug);

        }

        private void txtDrugName1_EditValueChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                GridLookUpEdit editor = (sender as GridLookUpEdit);

                DataRowView row = editor.Properties.GetRowByKeyValue(editor.EditValue) as DataRowView;
                XtraMessageBox.Show(row["drugName"].ToString());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }*/
        }

      
    }
}
