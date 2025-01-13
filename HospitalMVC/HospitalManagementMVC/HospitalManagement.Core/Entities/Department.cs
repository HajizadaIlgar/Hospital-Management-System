using HospitalManagement.Core.Entities.Common;

namespace HospitalManagement.Core.Entities
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
