using HospitalManagement.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace HospitalManagement.BL.ViewModels.Doctors;

public class DoctorListItemVM
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public IFormFile Image { get; set; }

    public static implicit operator Doctor(DoctorListItemVM vm)
    {
        Doctor dc = new Doctor
        {
            Name = vm.Name,
            Surname = vm.Surname,
            ImageUrl = vm.Image.Name,
        };
        return dc;
    }
}
