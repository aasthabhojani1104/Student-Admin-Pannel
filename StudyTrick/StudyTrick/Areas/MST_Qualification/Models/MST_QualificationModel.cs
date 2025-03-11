namespace StudyTrick.Areas.MST_Qualification.Models
{
    public class MST_QualificationModel
    {
        public int? QualificationID { get; set; }
        public string QualificationName { get; set; }
        public string? Description { get; set; }
    }

    public class MST_QualificationDropDownModel
    {
        public int? QualificationID { get; set; }
        public string QualificationName { get; set; }
    }
}
