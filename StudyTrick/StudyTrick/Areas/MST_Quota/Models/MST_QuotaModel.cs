namespace StudyTrick.Areas.MST_Quota.Models
{
    public class MST_QuotaModel
    {
        public int? QuotaID { get; set; }
        public int CourseID { get; set; }
        public string QuotaName { get; set; }
        public string? Description { get; set; }
    }

    public class MST_QuotaDropDownModel
    {
        public int? QuotaID { get; set; }
        public string QuotaName { get; set; }
    }
}