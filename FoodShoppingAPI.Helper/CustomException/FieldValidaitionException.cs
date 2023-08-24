using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Helper.CustomException
{
    public class FieldValidationException : Exception
    {

        public FieldValidationException(List<string> validationMessages)
        {
            base.Data["FieldValidationError"] = validationMessages;
        }
    }
}
