using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Validations
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class StartWith5Attribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            
            var inputValue = value as string;
            if(inputValue == "")
                return false;

            return inputValue[0] == '5';
        }
    }
}