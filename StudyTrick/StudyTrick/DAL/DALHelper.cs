namespace StudyTrick.DAL
{
    #region DAL Helper
    public class DALHelper
    {
        public static string myConnectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("myConnectionString");
    }
    #endregion
}
