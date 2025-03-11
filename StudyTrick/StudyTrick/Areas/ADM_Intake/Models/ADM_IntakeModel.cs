namespace StudyTrick.Areas.ADM_Intake.Models
{
    public class ADM_IntakeModel
    {
        public int? IntakeID { get; set; }
        public int AdmissionYearID { get; set; }
        public int ProgramID { get; set; }
        public int CourseID { get; set; }
        public int QuotaID { get; set; }
        public int Intake { get; set; }
        public string? Description { get; set; }
    }
}
