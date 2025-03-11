namespace StudyTrick.Areas.MST_Course.Models
{
    public class MST_CourseModel
    {
        public int? CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseLevel { get; set; }
        public string CourseDuration { get; set; }
        public string? Description { get; set; }
    }

    public class MST_CourseDropDownModel
    {
        public int CourseID { get; set; }
        public string? CourseName { get; set; }
    }
}
