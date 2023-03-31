using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using mvcapi.Models;

namespace mvcapi.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SqlDbContext db = new SqlDbContext();
        public async Task Add(employee emp)
        {
            emp.id = int.Parse(Guid.NewGuid().ToString());
            db.employees.Add(emp);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }

        }

        public async Task Delete(string id)
        {
            try
            {
                employee emp = await db.employees.FindAsync(id);
                db.employees.Remove(emp);
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<employee> GetEmployee(string id)
        {
            try
            {
                employee emp = await db.employees.FindAsync(id);
                if(emp==null)
                {
                    return null;
                }
                return emp;
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<employee>> GetEmployees()
        {
            try
            {
                var emp = await db.employees.ToListAsync();
                return emp.AsQueryable();
            }
            catch
            {
                throw;
            }
        }

        public async Task Update(employee emp)
        {
            try
            {
                db.Entry(emp).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        private bool employeeexists(string id)
        {
            return db.employees.Count(e => e.id==int.Parse(id))>0;
        }
    }
}