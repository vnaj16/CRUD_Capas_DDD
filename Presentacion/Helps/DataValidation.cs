using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Presentacion.Helps
{
    public class DataValidation
    {
        private ValidationContext Context;
        private List<ValidationResult> Results;

        private bool Valid;
        private string Message;

        public DataValidation(object instance)
        {
            Context = new ValidationContext(instance);
            Results = new List<ValidationResult>();
            Valid = Validator.TryValidateObject(instance, Context, Results,true);
        }

        public bool Validate()
        {
            if (Valid != true)
            {
                foreach (ValidationResult item in Results)
                {
                    Message = item.ErrorMessage + "\n";
                }
                System.Windows.Forms.MessageBox.Show(Message);
            }

            return Valid;
        }
    }
}
