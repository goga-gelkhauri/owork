using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Api.Validations
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ContainsOnlyNumbersAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var inputValue = value as string;

            return inputValue.All(char.IsDigit);
        }
    }
}