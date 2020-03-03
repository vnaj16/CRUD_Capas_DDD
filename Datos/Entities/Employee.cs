using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public DateTime Birthday { get; set; }
    }
}
