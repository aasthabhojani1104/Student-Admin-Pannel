namespace StudyTrick.Areas.MST_Program.Models
{
    public class MST_ProgramModel
    {
        public int? ProgramID { get; set; }
        public int CourseID { get; set; }
        public string ProgramName { get; set; }
        public string? Description { get; set; }
    }

    public class MST_ProgramDropDownModel
    {
        public int? ProgramID { get; set; }
        public string ProgramName { get; set; }
    }
}