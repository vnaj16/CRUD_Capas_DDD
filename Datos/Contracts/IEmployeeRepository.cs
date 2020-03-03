using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contracts
{
    public interface IEmployeeRepository: IGenericRepository<Employee>
    {
        //Other methods
        IEnumerable<Employee> GetByBirthday(DateTime Birthday);

        //IEnumerable<Employee> GetBySalary();
    }
}
