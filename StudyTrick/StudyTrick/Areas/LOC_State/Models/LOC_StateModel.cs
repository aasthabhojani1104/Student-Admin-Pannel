using System.ComponentModel.DataAnnotations;

namespace StudyTrick.Areas.LOC_State.Models
{
    public class LOC_StateModel
    {
        public int? StateID { get; set; }

        [Required(ErrorMessage = "Please enter valid state name")]
        [StringLength(20, MinimumLength = 3)]
        public string? StateName { get; set; }
        public string? Description { get; set; }
    }

    public class LOC_StateDropDownModel
    {
        public int StateID { get; set; }
        public string? StateName { get; set; }
    }
}
