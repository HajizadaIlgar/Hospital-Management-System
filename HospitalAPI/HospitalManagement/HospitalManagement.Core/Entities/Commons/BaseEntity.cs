namespace HospitalManagement.Core.Entities.Commons;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public DateTime DeleteAt { get; set; }
    public bool IsDeleted { get; set; }
}
