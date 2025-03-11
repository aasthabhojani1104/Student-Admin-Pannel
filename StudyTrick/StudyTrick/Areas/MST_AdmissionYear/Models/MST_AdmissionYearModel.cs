using System.ComponentModel.DataAnnotations;

namespace StudyTrick.Areas.MST_AdmissionYear.Models
{
    public class MST_AdmissionYearModel
    {
        public int? AdmissionYearID { get; set; }

        [Required(ErrorMessage = "Please enter valid admission year")]
        public int AdmissionYear { get; set; }
        public string? Description { get; set; }
    }

    public class MST_AdmissionYearDropDownModel
    {
        public int AdmissionYearID { get; set; }
        public int AdmissionYear { get; set; }

    }
}
