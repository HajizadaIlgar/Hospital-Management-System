namespace HospitalManagement.Core.Entities.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
