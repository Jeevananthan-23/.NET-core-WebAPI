using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApI.Shared;

namespace WebAPI.Service.Models
{
    public interface IDepartmentRepo
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartmentById(int departmentId);
    }
}
