using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class LOC_StateDAL : LOC_StateDALBase
    {
        public DataTable dbo_PR_LOC_State_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbCity = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCity = sqlDbCity.GetStoredProcCommand("dbo.PR_LOC_State_SelectForDropDown");
                sqlDbCity.AddInParameter(dbCmdCity, "UserID", SqlDbType.Int, UserID);

                DataTable dtCity = new DataTable();
                using (IDataReader drCity = sqlDbCity.ExecuteReader(dbCmdCity))
                {
                    dtCity.Load(drCity);
                }

                return dtCity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
