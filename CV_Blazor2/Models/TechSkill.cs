using System.ComponentModel.DataAnnotations;

namespace CV_Blazor2.Models
{
    public class TechSkill
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Namn på teknisk färdighet krävs.")]
        public string Name { get; set; } = string.Empty;

        [Range(0, 50, ErrorMessage = "Antal år måste vara mellan 0 och 50.")]
        public int Years { get; set; }

        [Range(1, 10, ErrorMessage = "Skill Level måste vara mellan 1 och 10.")]
        public int SkillLevel { get; set; }
    }
}
