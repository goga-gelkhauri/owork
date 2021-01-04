using System.ComponentModel.DataAnnotations;
using Api.Validations;

namespace Api.Dto
{
    public class MobileDto
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Phone Number is Required")]
        [StartWith5Attribute(ErrorMessage = "Phone Number Must Start With 5")]
        [StringLength(9,MinimumLength = 9,ErrorMessage = "Phone Number should be 9 digits")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Amount is Required")]
        [Range(typeof(float), "1", "100",ErrorMessage = "amount should be between 1 and 100")]
        public float Amount { get; set; }
        public float Commission { get; set; }
        public string Service { get; set; } 
        
    }
}