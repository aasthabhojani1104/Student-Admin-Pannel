namespace StudyTrick.Areas.MST_Document.Models
{
    public class MST_DocumentModel
    {
        public int? DocumentID { get; set; }
        public string DocumentName { get; set; }
        public string? Description { get; set; }
    }

    public class MST_DocumentDropDownModel
    {
        public int? DocumentID { get; set; }
        public string DocumentName { get; set; }
    }
}