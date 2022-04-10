namespace MedicalServiceCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inquiry")]
    public partial class Inquiry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inquiry()
        {
            Sales = new HashSet<Sale>();
        }

        [Key]
        [StringLength(50)]
        public string PatientEmail { get; set; }

        [Required]
        [StringLength(50)]
        public string PatientFullName { get; set; }

        public long? PhoneNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string InquiryStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string SourceOfInquiry { get; set; }

        public int TreatmentID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }

        public virtual Treatment Treatment { get; set; }

    }
}
