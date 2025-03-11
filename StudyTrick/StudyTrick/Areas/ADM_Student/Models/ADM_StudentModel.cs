using System.ComponentModel.DataAnnotations;

namespace StudyTrick.Areas.ADM_Student.Models
{
    public class ADM_StudentModel
    {
        public int? StudentID { get; set; }
        [Required(ErrorMessage = "Please select visitor")]
        public int VisitorID { get; set; }
        [Required(ErrorMessage = "Please enter valid name")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Please select admission year")]
        public int AdmissionYearID { get; set; }
        [Required(ErrorMessage = "Please select quota")]
        public int QuotaID { get; set; }
        [Required(ErrorMessage = "Please select course")]
        public int CourseID { get; set; }
        [Required(ErrorMessage = "Please select program")]
        public int ProgramID { get; set; }
        [Required(ErrorMessage ="Please select qualification")]
        public int QualificationID { get; set; }
        [Required(ErrorMessage = "Please select caste category")]
        public int CasteCategoryID { get; set; }
        public int? StateID { get; set; }
        public int? CityID { get; set; }
        [Required(ErrorMessage = "Please enter valid phone number")]
        public string ParentPhone { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal? SSCPercentage { get; set; }
        public string? SSCSchoolName { get; set; }
        public int? SSCPassingYear { get; set; }
        public decimal? HSCPercentage { get; set; }
        public string? HSCSchoolName { get; set; }
        public int? HSCPassingYear { get; set; }
        public decimal? DiplomaPercentage { get; set; }
        public string? DiplomaCollegeName { get; set; }
        public int? DiplomaPassingYear { get; set; }
        public decimal? UGPercentage { get; set; }
        public string? UGCollegeName { get; set; }
        public int? UGPassingYear { get; set; }
        public decimal? PGPercentage { get; set; }
        public string? PGCollegeName { get; set; }
        public int? PGPassingYear { get; set; }
        public IFormFile? File { get; set; }
        public string? PhotoPath { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }

    public class ADM_StudentDropDownModel
    {
        public int? StudentID { get; set; }
        public string StudentName { get; set; }
    }
}
