using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using mvcapi.Models;

namespace mvcapi.Repository
{
    public interface IEmployeeRepository
    {
        Task Add(employee emp);
        Task Update(employee emp);
        Task Delete(string id);
        Task<employee> GetEmployee(string id);
        Task<IEnumerable<employee>> GetEmployees();

    }
}