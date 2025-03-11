namespace StudyTrick.Areas.MST_CourseWiseDocument.Models
{
    public class MST_CourseWiseDocumentModel
    {
        public int? CourseWiseDocumentID { get; set; }
        public int CourseID { get; set; }
        public int DocumentID { get; set; }
        public int AdmissionYearID { get; set; }
        public string? Description {get; set; }
    }
}
