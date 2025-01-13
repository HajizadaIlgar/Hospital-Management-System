using HospitalManagement.BL.ViewModels.Doctors;

namespace HospitalManagement.BL.Services.Interfaces;

public interface IDoctorService
{
    Task<IEnumerable<DoctorListItemVM>> GetAllAsync();
    Task<int> CreateAsync(DoctorVM doctorVM);
}
