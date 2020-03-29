using System.ComponentModel.DataAnnotations;

namespace ANC.React.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}