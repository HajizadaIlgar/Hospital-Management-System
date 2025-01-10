using HospitalManagement.Core.Entities.Commons;

namespace HospitalManagement.Core.Entities;

public class Insurance : BaseEntity
{
    public string PersonInsurance { get; set; }
    public float Discount { get; set; }
    public ICollection<Patient> Patients { get; set; }
}
