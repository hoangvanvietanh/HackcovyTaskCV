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
    class PrescriptionServices
    {
        private IPrescriptionDao prescriptionDao = new PrescriptionDaoImpl();
        private IDrugInPrescriptionDao drugInPrescriptionDao = new DrugInPrescriptionDaoImpl();
        private NodeJSServices nodeJS = new NodeJSServices();


        public void createPrescription(Prescription prescription, List<DrugInPrescription> drugInPrescriptions, string emailUser)
        {
            Prescription pre = prescriptionDao.createPrescription(prescription);
            List<DrugNodejs> listDrugNodejs = new List<DrugNodejs>();

            drugInPrescriptions.ForEach(drug =>
            {
                drug.idPrescription = pre.idPrescription;
                drugInPrescriptionDao.createDrugInPrescription(drug);
                DrugNodejs dr = new DrugNodejs();
                dr.AmountOfMedicine = drug.amountOfMedicine.ToString();
                dr.Color = drug.color.ToString();
                dr.Dosage = drug.dosage.ToString();
                dr.DrugName = drug.drugName;
                dr.Image = drug.image;
                dr.Time = drug.time;
                listDrugNodejs.Add(dr);
            });

            PrescriptionNodejs prescriptionNodejs = new PrescriptionNodejs();
            prescriptionNodejs.Date = pre.date;
            prescriptionNodejs.Diagnostic = pre.diagnostic;
            prescriptionNodejs.Notes = pre.notes;
            prescriptionNodejs.ReExamination = pre.reExamination;
            prescriptionNodejs.Share = pre.emailShare;
            prescriptionNodejs.Drugs = listDrugNodejs;
            EmailAndReminder emailAndReminder = new EmailAndReminder();
            emailAndReminder.Email = emailUser;
            emailAndReminder.Reminder = prescriptionNodejs;
             nodeJS.createReminderOnNodejs(emailAndReminder);


        }
    }
}
