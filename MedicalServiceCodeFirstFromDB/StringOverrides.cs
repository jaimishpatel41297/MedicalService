using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
///All string overrides are here.
/// </summary>
///
namespace MedicalServiceCodeFirstFromDB
{


    /// <summary>
    /// For debugging
    /// </summary>
    /// <returns></returns>
    partial class Doctor
    {
        public override string ToString()
        {
            return DoctorID + ": " + DoctorName + " " + DoctorPhone;
        }

    }


    /// <summary>
    /// For debugging
    /// </summary>
    /// <returns></returns>
    partial class Treatment
    {
        public override string ToString()
        {
            return TreatmentID + ": " + TreatmentName + " " + TreatmentPrice + " :DoctorID= " + DoctorID;
        }

    }
    partial class Inquiry
    {
        public override string ToString()
        {
            return PatientEmail;
        }

    }

    partial class Sale
    {
        public override string ToString()
        {
            return "Patient Email: " + PatientEmail + " || " + "DocID: " + DoctorID + " || " +
                "TreatmentID: " + TreatmentID + " || " + "PatientsName: " + PatientsFullName + " || " +
                "PhoneNumber: " + PhoneNumber + " || " + "DepositRequired: " + DepositRequired + " || " +
                "TotalRemainingBalance: " + TotalRemainingBalance + " || " +
                "RemainingBalanceToDoctor: " + RemainingBalanceToDoctor + " || " +
                "NetProfit: " + NetProfit + " || " + "AppointmentDate: " + DoctorAppointedDate;
        }

    }

}
