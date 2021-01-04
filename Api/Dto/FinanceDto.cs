using System.ComponentModel.DataAnnotations;
using Api.Validations;

namespace Api.Dto
{
    public class FinanceDto
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Phone Number is Required")]
        [StringLength(9,MinimumLength = 9,ErrorMessage = "Phone Number should be 9 digits")]
        [StartWith5Attribute(ErrorMessage = "Phone Number Must Start With 5")]
        public string PhoneNumber { get; set; }

        [Range(typeof(float), "1", "100",ErrorMessage = "amount should be between 1 and 100")]
        public float Amount { get; set; }

        public float Commission { get; set; }

        public string Service { get; set; } 

        [Required(ErrorMessage = "Personal Number is Required")]
        [StringLength(11,MinimumLength=11,ErrorMessage = "Personal Number should be 11 digits")]
        [ContainsOnlyNumbersAttribute(ErrorMessage = "Personal Number Should Only Contain Numbers")]
        public string PersonalNumber { get; set; }

        [Required(ErrorMessage = "Account Number is Required")]
        [StringLength(22,MinimumLength=22,ErrorMessage = "Account Number should be 22 digits")]
        [AccountNumberAttribure(ErrorMessage = "Invalid Account number Format")]
        public string AccountNumber { get; set; }
        
    }
}