namespace StudyTrick.Areas.MST_Staff.Models
{
    public class MST_StaffModel
    {
        public int? StaffID { get; set; }
        public string StaffName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string StaffCode { get; set; }
        public string? Description { get; set; }
    }

    public class MST_StaffDropDownModel
    {
        public int? StaffID { get; set; }
        public string StaffName { get; set; }
    }
}
