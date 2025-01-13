using HospitalManagement.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace HospitalManagement.BL.ViewModels.Doctors;

public class DoctorVM
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int DepaertmentId { get; set; }
    public IFormFile ImageUrl { get; set; }

    public static implicit operator Doctor(DoctorVM vm)
    {
        Doctor dc = new Doctor
        {
            Name = vm.Name,
            Surname = vm.Surname,
            ImageUrl = vm.ImageUrl.Name,
        };
        return dc;
    }
}
