using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Api.Validations
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class AmountRequiredAttribure : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var inputValue = value as string;
            if(inputValue == "0")
                return false;

            return inputValue.All(char.IsDigit);
        }
    }
}