using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalServiceCodeFirstFromDB;

namespace MedicalServiceValidation
{
    public static class TreatmentValidation
    {
        /// <summary>
        /// validation to ensure that treatment with same name and doctorID does not exist in database.
        /// </summary>
        /// <param name="treatment"></param>
        /// <returns></returns>
        public static bool TreatmentExists(this Treatment treatment)
        {
            using (MedicalServiceEntities context = new MedicalServiceEntities())
            {
                return (context.Treatments.Any(c => c.TreatmentName == treatment.TreatmentName && c.DoctorID == treatment.DoctorID));

            }

        }
        /// <summary>
        /// Check the treatment has all valid data into it.
        /// </summary>
        /// <param name="treatment"></param>
        /// <returns></returns>
        public static bool EntryIsInValid(this Treatment treatment)
        {
            return (treatment.TreatmentName == null || treatment.TreatmentName.Trim().Length == 0 || treatment.TreatmentPrice.ToString() == null || treatment.TreatmentPrice.ToString().Trim().Length == 0);
        }


    }
}
