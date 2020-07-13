using Payroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Services
{
    // creating a DataService class implementing the IDataService interface

    // The Data Service will deal with data - so it should support CRUD operations.
    // For sake of this sample project we will implement only two methods in the DataService class
    // one that returns all the Employee records and another the searches for an Employee record by Id and returns it.
    // The DataService class also holds a list of Employee records -- the data here is hardcoded.
    public class DataService : IDataService
    {
        private readonly List<Empolyee> lstEmployee = new List<Empolyee>();

        public DataService()
        {
            Empolyee empolyee = new Empolyee();
            empolyee.Id = 1;
            empolyee.FirstName = "Sam";
            empolyee.LastName = "Fisher";
            empolyee.Address = "Canada";
            lstEmployee.Add(empolyee);
        }
        public List<Empolyee> Get()
        {
            if (lstEmployee.Count > 0)
                return lstEmployee;
            return null;
        }
        public Empolyee GetById(int id)
        {
            foreach (var emp in lstEmployee)
            {
                if (emp.Id == id)
                    return emp;
            }
            return null;
        }
    }
}
