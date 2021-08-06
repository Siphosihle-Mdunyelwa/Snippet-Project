using System.ComponentModel.DataAnnotations;

namespace Snippet.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}