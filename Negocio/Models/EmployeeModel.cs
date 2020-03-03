using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entities;
using Datos.Contracts;
using Datos.Repositories;
using Negocio.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace Negocio.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "DNI is Required")]
        [RegularExpression("([0-9]+)", ErrorMessage = "DNI must be only numbers")]
        [StringLength(maximumLength: 8, MinimumLength = 8, ErrorMessage = "DNI must be 8 digits")]
        public string DNI { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z ]+$")]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Mail { get; set; }

        public DateTime Birthday { get; set; }
        public int Edad { get; private set; }

        private IEmployeeRepository employeeRepository;
        public EntityState State { private get; set; }

        public EmployeeModel()
        {
            employeeRepository = new EmployeeRepository();
        }

        public string SaveChanges()
        {
            string message=null;
            try
            {
                Employee employeeDataModel = new Employee();
                employeeDataModel.ID = ID;
                employeeDataModel.DNI = DNI;
                employeeDataModel.Nombre = Nombre;
                employeeDataModel.Mail = Mail;
                employeeDataModel.Birthday = Birthday;

                switch (State)
                {
                    case EntityState.Added:
                        //Ejecutar reglas comerciales
                        employeeRepository.Add(employeeDataModel);
                        message = "Successfully Added";
                        break;
                    case EntityState.Deleted:
                        //Ejecutar reglas comerciales
                        employeeRepository.Remove(ID);
                        message = "Successfully Removed";
                        break;
                    case EntityState.Modified:
                        //Ejecutar reglas comerciales
                        employeeRepository.Edit(employeeDataModel);
                        message = "Successfully Edited";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;

                if (sqlEx != null && sqlEx.Number == 2627)
                    message = "Duplicate record";
                else
                    message = ex.Message;
            }

            return message;
        }


    }
}
