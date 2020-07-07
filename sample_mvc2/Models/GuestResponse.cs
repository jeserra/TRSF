using System.ComponentModel.DataAnnotations;

namespace sample_mvc2.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Favor de introducir tu nombre")]
        public string Name {get;set;}
        [Required(ErrorMessage = "Favor de introducir correo electronico")]
        [EmailAddress]
        public string Email {get;set;}
        [Required(ErrorMessage = "Favor de introducir tu telefono")]
        public string Phone {get;set;}
        [Required(ErrorMessage = "Especificar si vasir o no vasir")]
        public bool? WillAttend {get;set;}
    }
}