using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        public string Username {get;set;}

        [Required]
        [StringLength(9, MinimumLength=4, ErrorMessage="You must specify a password between 4 and 8 characters")]
        public string Password {get;set;}
    }
}