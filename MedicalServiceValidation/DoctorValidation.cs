using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalServiceCodeFirstFromDB;
using System.Diagnostics;

namespace MedicalServiceValidation
{

    public static class DoctorValidation
    {
        /// <summary>
        /// validate and check if we alredy have that doctor in system or not
        /// </summary>
        /// <param name="doctor"></param>
        /// <returns></returns>
        public static bool DoctorNAmeExists(this Doctor doctor)
        {
            using (MedicalServiceEntities context = new MedicalServiceEntities())
            {
                context.Database.Log = (s => Debug.Write(s));
                return context.Doctors.Any(d => d.DoctorName == doctor.DoctorName);
            }
        }

        /// <summary>
        /// Chgeck doctor data is it valid or not
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public static bool EntryIsInValid(this Doctor doctor)
        {
            return (doctor.DoctorName == null || doctor.DoctorName.Trim().Length == 0);
        }

    }
}
