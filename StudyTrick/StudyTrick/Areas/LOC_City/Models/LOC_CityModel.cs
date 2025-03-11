using System.ComponentModel.DataAnnotations;

namespace StudyTrick.Areas.LOC_City.Models
{
    public class LOC_CityModel
    {
        public int? CityID { get; set; }

        [Required(ErrorMessage = "Please select state name")]
        public int StateID { get; set; }

        [Required(ErrorMessage = "Please enter valid city name")]
        [StringLength(20, MinimumLength = 3)]
        public string? CityName { get; set; }
        public string? Description { get; set; }
    }

    public class LOC_CityDropDownModel
    {
        public int? CityID { get; set; }
        public string? CityName { get; set; }
    }

}
