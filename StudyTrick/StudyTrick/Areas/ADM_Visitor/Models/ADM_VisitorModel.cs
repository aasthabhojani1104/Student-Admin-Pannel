using System.ComponentModel.DataAnnotations;

namespace StudyTrick.Areas.ADM_Visitor.Models
{
    public class ADM_VisitorModel
    {
        public ADM_VisitorModel()
        {
            InterestedCoursesID = new List<int>();
            InterestedCoursesName = new List<string>();
        }
        public int? VisitorID { get; set; }
        public int AdmissionYearID { get; set; }
        public string? AdmissionYear { get; set; }
        public int? CounsellorStaffID { get; set; }
        public string? CounsellorStaffName { get; set; }
        public int? VisitorStaffID { get; set; }
        public string? VisitorStaffName { get; set; }
        public string VisitorName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int? NoOfPeople { get; set; }
        public string Address { get; set; }
        public DateTime? PassingYear { get; set; }
        public List<int> InterestedCoursesID { get; set; }
        public List<string> InterestedCoursesName { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public object StudentName { get; internal set; }
    }

    public class ADM_VisitorDropDownModel
    {
        public int? VisitorID { get; set; }
        public string? VisitorName { get; set; }
    }
}
