using System.ComponentModel.DataAnnotations;

namespace Metrodev.ABMExample.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}