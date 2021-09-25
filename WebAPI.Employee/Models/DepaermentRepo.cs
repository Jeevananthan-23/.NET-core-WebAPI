using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Server.Models;
using WebApI.Shared;

namespace WebAPI.Service.Models
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly AppDbContext appDbContext;

        public DepartmentRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Department> GetDepartmentById(int departmentId)
        {
            return appDbContext.Departments.FirstOrDefault(c => c.DepartmentId == departmentId);
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await appDbContext.Departments.ToListAsync();
        }
    }
}
