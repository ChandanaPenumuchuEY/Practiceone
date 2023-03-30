using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspcoreapi.Models;

namespace aspcoreapi.Repositories
{
    public class EmployeeRepository : IEmloyeeRepository
    {
      //  private readonly dbcontext

        public bool DeleteEmployee(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> InsertEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
