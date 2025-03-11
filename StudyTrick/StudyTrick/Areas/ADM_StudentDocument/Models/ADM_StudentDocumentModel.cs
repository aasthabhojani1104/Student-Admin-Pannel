namespace StudyTrick.Areas.ADM_StudentDocument.Models
{
    public class ADM_StudentDocumentModel
    {
        public int? StudentDocumentID { get; set; }
        public int StudentID { get; set; }
        public int DocumentID { get; set; }
        public IFormFile? File { get; set; }
        public string? DocumentPath { get; set; }
        public string? Description { get; set; }
    }
}
