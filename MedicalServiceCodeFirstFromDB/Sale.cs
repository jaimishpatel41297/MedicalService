namespace MedicalServiceCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sale
    {
        [Key]
        public int SalesID { get; set; }

        [Required]
        [StringLength(50)]
        public string PatientEmail { get; set; }

        public int DoctorID { get; set; }

        public int TreatmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string PatientsFullName { get; set; }

        public long PhoneNumber { get; set; }

        public long DepositRequired { get; set; }

        public long TotalRemainingBalance { get; set; }

        public long RemainingBalanceToDoctor { get; set; }

        public long NetProfit { get; set; }

        [Column(TypeName = "date")]
        public DateTime DoctorAppointedDate { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Inquiry Inquiry { get; set; }

        public virtual Treatment Treatment { get; set; }
    }
}
