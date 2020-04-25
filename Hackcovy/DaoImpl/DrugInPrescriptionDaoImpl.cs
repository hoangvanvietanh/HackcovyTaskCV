using Hackcovy.Dao;
using Hackcovy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackcovy.DaoImpl
{
    class DrugInPrescriptionDaoImpl : IDrugInPrescriptionDao
    {
        private LinQDataContext db;
        private List<DrugInPrescription> drugInPrescriptions;

        public DrugInPrescriptionDaoImpl()
        {
            db = new LinQDataContext();
            using (db)
            {
                var drugInPrescription = from x in db.DrugInPrescriptions select x;
                drugInPrescriptions = drugInPrescription.ToList();
            }
        }
        public DrugInPrescription createDrugInPrescription(DrugInPrescription drugInPrescription)
        {
            db = new LinQDataContext();
            DrugInPrescription drug = new DrugInPrescription();
            drug = drugInPrescription;
            db.DrugInPrescriptions.InsertOnSubmit(drug);
            db.SubmitChanges();
            return drug;
        }
    }
}
