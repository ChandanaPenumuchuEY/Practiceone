using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspcoreapi.Models;

namespace aspcoreapi.Repositories
{
    public interface IEmloyeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployeeByID(int ID);
        Task<Employee> InsertEmployee();
        Task<Employee> UpdateEmployee();

        bool DeleteEmployee(int ID);

    }
}
