using Hackcovy.Dao;
using Hackcovy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackcovy.DaoImpl
{
    class PrescriptionDaoImpl : IPrescriptionDao
    {
        private LinQDataContext db;
        private List<Prescription> prescriptions;

        public PrescriptionDaoImpl()
        {
            db = new LinQDataContext();
            using (db)
            {
                var prescription = from x in db.Prescriptions select x;
                prescriptions = prescription.ToList();
            }
        }

        public Prescription createPrescription(Prescription prescription)
        {
            db = new LinQDataContext();
            Prescription pre = new Prescription();
            pre = prescription;
            db.Prescriptions.InsertOnSubmit(pre);
            db.SubmitChanges();
            return pre;
        }
    }
}
