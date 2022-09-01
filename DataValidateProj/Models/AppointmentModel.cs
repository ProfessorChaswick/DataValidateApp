using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataValidateProj.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(30, MinimumLength = 4)]
        [DisplayName("Patient's Full Name")]
        public string PatientName { get; set; }
        [DisplayName("Street Address")]
        public string Street { get; set; }
        public string City { get; set; }
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [DisplayName("10 digit Phone Number")]
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Appoint Request Date")]
        public DateTime AppointmentDate { get; set; }
        [DataType(DataType.Currency)]
        [DisplayName("Patient's Approximate Net Worth")]
        public decimal PatientNetWorth { get; set; }

        [DisplayName("Doctor's Name")]
        public string DoctorName { get; set; }
        [Range(1,10)]
        [DisplayName("Patient's pain Level (1 for low + 10 for high)")]
        public int PainLevel { get; set; }

    }
}
