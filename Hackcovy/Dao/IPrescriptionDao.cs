using Hackcovy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackcovy.Dao
{
    interface IPrescriptionDao
    {
        Prescription createPrescription(Prescription prescription);
    }
}
