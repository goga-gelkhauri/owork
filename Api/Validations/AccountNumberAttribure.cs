using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Api.Validations
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class AccountNumberAttribure : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var accountNumber = value as string;
            if(accountNumber.Length != 22)
            {
                return false;
            }
            if(accountNumber[0] != 'G' | accountNumber[1] !='E')
            {
                return false;
            }

            if (!char.IsDigit(accountNumber[2]) | !char.IsDigit(accountNumber[3]))
            {
                return false;
            }

            var str = accountNumber.Substring(6, accountNumber.Length - 6);
            if(!str.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }
    }
}