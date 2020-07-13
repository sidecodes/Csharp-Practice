using Payroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Services
{
    // Creating an Interface of DataServices
    public interface IDataService
    {
        List<Empolyee> Get();
        Empolyee GetById(int id);
    }
}
