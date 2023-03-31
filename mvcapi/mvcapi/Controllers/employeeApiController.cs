

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using mvcapi.Models;
using mvcapi.Repository;

namespace mvcapi.Controllers
{
    public class employeeApiController : ApiController
    {
        private readonly IEmployeeRepository _iemployeerepository = new EmployeeRepository();
        [HttpGet]
        [Route("api/employees/Get")]
        public async Task<IEnumerable<employee>> Get()
        {
            return await _iemployeerepository.GetEmployees();
        }

        [HttpGet]
        [Route("api/employees/Create")]
        public async Task CreateAsync([FromBody] employee emp)
        {
            if (ModelState.IsValid)
            {
                await _iemployeerepository.Add(emp);
            }
        }

        [HttpGet]
        [Route("api/employees/Details/{id}")]
        public async Task<employee> Details(string id)
        {
            var result = await _iemployeerepository.GetEmployee(id);
            return result;
        }
        public string Get(int id)
        {
            return "value";
        }

    
        [HttpGet]
        [Route("api/employees/Delete/{id}")]
        public async Task DeleteConfirmedAsync(string id)
        {
            await _iemployeerepository.Delete(id);
        }
    }
}