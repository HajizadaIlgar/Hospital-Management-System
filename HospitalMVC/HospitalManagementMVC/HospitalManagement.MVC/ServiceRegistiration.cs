using HospitalManagement.BL.Services.Implements;
using HospitalManagement.BL.Services.Interfaces;
using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Repositories;
using HospitalManagement.DAL.Repositories;

namespace HospitalManagement.MVC;

public static class ServiceRegistiration
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        services.AddScoped<IGenericRepository<Doctor>, GenericRepository<Doctor>>();
        services.AddScoped<IDoctorRepository, DoctorRepository>();
        services.AddScoped<IDoctorService, DoctorService>();
        return services;
    }
}
