using HospitalManagement.BL.Services.Interfaces;
using HospitalManagement.BL.ViewModels.Doctors;
using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Repositories;

namespace HospitalManagement.BL.Services.Implements
{
    public class DoctorService(IDoctorRepository _repo) : IDoctorService
    {
        public async Task<int> CreateAsync(DoctorVM doctorVM)
        {
            Doctor dc = doctorVM;
            await _repo.AddAsync(doctorVM);
            await _repo.SaveAsync();
            return dc.Id;
        }

        public async Task<IEnumerable<DoctorListItemVM>> GetAllAsync()
        {
            return null;
        }
    }
}
