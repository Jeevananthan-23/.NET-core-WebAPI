using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApI.Shared;

namespace WebApi.Server.Models
{
    public interface IEmpolyeeRepo
    {
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task DeleteEmployee(int employeeId);
    }
}
