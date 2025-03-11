namespace StudyTrick.Areas.MST_CasteCategory.Models
{
    public class MST_CasteCategoryModel
    {
        public int? CasteCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
    }

    public class MST_CasteCategoryDropDownModel
    {
        public int? CasteCategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
