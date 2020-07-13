using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Payroll.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // Taking advantage of constructor injection to inject an instance of type IDataService
        private readonly IDataService _dataService;
        public EmployeeController(IDataService dataService)
        {
            _dataService = dataService;
        }
        // The following controller method retrives all employee records and returns the list

        /*
         *   ASP.NET Core provides you three ways to return data from an action method: 
         *   an instance of a specific type, an instance of type IActionResult and an instance of the generic type IActionResult<T>. 
         *   IActionResult helps you to return error or status codes of an operation.
        */
        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult Get()
        {
            var records = _dataService.Get();
            if (records != null)
                if (records.Count > 0)
                    return Ok(records);
            return NotFound();
        }

        // Another action method -- this one accepts an integer value (the employee id)
        // as an argument and returns, searches for a record with the given id and if found returns the employee record.

        // GET api/<EmployeeController>/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var data = _dataService.GetById(id);
            if (data != null)
                return Ok(data);
            return NotFound();
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //TODO: Write code here to create an employee record.
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //TODO: Write code here to update an employee record.
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO: Write code here to delete an employee record.
        }
    }
}
