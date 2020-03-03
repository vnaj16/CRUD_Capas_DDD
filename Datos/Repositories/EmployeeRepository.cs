using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Contracts;
using Datos.Entities;

namespace Datos.Repositories
{
    public class EmployeeRepository : MasterRepository, IEmployeeRepository
    {
        //campos
        private string SelectAll;
        private string SelectByBirthday;
        private string Insert;
        private string Update;
        private string Delete;

        //properties

        //constructor
        public EmployeeRepository()
        {
            SelectAll = "SELECT * FROM Employee";
            SelectByBirthday = "SELECT * FROM Employee WHERE Birthday = @Birthday";
            Insert = "INSERT INTO Employee VALUES(@DNI, @Nombre, @Mail, @Birthday)";
            Update = "UPDATE Employee SET DNI = @DNI, Nombre = @Nombre, Mail = @Mail, Birthday = @Birthday WHERE ID = @ID";
            Delete = "DELETE FROM Employee WHERE ID = @ID";
        }


        //Metodos, comportamiento
        public IEnumerable<Employee> GetAll()
        {
            var tableResult = ExecuteReader(SelectAll);
            var Lista_Employees = new List<Employee>();

            foreach (DataRow item in tableResult.Rows)
            {
                Lista_Employees.Add(new Employee()
                {
                    ID = Convert.ToInt32(item["ID"]),
                    DNI = item["DNI"].ToString(),
                    Nombre = item["Nombre"].ToString(),
                    Mail = item["Mail"].ToString(),
                    Birthday = Convert.ToDateTime(item["Birthday"]),
                });
            }

            return Lista_Employees;
        }

        public IEnumerable<Employee> GetByBirthday(DateTime Birthday)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@Birthday", Birthday));
            var tableResult = ExecuteReader(SelectByBirthday);
            var Lista_Employees = new List<Employee>();

            foreach (DataRow item in tableResult.Rows)
            {
                Lista_Employees.Add(new Employee()
                {
                    ID = Convert.ToInt32(item["ID"]),
                    DNI = item["DNI"].ToString(),
                    Nombre = item["Nombre"].ToString(),
                    Mail = item["Mail"].ToString(),
                    Birthday = Convert.ToDateTime(item["Birthday"]),
                });
            }

            return Lista_Employees;
        }

        public int Add(Employee entity)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@DNI", entity.DNI));
            Parameters.Add(new SqlParameter("@Nombre", entity.Nombre));
            Parameters.Add(new SqlParameter("@Mail", entity.Mail));
            Parameters.Add(new SqlParameter("@Birthday", entity.Birthday));

            return ExecuteNonQuery(Insert);
        }

        public int Edit(Employee entity)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@ID", entity.ID));
            Parameters.Add(new SqlParameter("@DNI", entity.DNI));
            Parameters.Add(new SqlParameter("@Nombre", entity.Nombre));
            Parameters.Add(new SqlParameter("@Mail", entity.Mail));
            Parameters.Add(new SqlParameter("@Birthday", entity.Birthday));

            return ExecuteNonQuery(Update);
        }

        public int Remove(int ID)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@ID", ID));

            return ExecuteNonQuery(Delete);
        }
    }
}
