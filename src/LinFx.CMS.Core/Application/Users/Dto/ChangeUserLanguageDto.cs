using System.ComponentModel.DataAnnotations;

namespace LinFx.CMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}