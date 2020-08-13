using System.ComponentModel.DataAnnotations;

namespace myabpweb.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}