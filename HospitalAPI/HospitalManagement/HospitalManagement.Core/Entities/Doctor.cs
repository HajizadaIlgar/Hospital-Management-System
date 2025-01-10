using HospitalManagement.Core.Entities.Commons;

namespace HospitalManagement.Core.Entities
{
    public class Doctor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Specialization { get; set; }
        public string LicenseNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public string OfficeAddress { get; set; }
        public ICollection<Patient> Patients { get; set; }

    }
}
