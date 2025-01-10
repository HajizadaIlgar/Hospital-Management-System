using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Repositories;
using HospitalManagement.DAL.Contexts;

namespace HospitalManagement.DAL.Repositories;

public class InsuranceRepository : GenericRepository<Insurance>, IInsuranceRepository
{
    public InsuranceRepository(HospitalManagementDbContext _context) : base(_context) { }
}
