using HospitalManagement.Core.Entities;

namespace HospitalManagement.BL.ViewModels.Departments;

public class DepartmentVM
{
    public string DepartmentName { get; set; }
    public static implicit operator Department(DepartmentVM vm)
    {
        Department dp = new Department
        {
            DepartmentName = vm.DepartmentName,
        };
        return dp;
    }
}
