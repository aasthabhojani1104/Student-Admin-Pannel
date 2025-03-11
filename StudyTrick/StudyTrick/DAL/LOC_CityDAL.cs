using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class LOC_CityDAL : LOC_CityDALBase
    {
        #region dbo.PR_LOC_City_SelectForDropDown
        public DataTable dbo_PR_LOC_City_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbCity = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCity = sqlDbCity.GetStoredProcCommand("dbo.PR_LOC_City_SelectForDropDown");
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
        #endregion

        #region dbo.PR_LOC_City_SelectDropDownByStateID
        public DataTable dbo_PR_LOC_City_SelectDropDownByStateID(int UserID, int? StateID)
        {
            try
            {
                SqlDatabase sqlDbCity = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCity = sqlDbCity.GetStoredProcCommand("dbo.PR_LOC_City_SelectDropDownByStateID");
                sqlDbCity.AddInParameter(dbCmdCity, "StateID", SqlDbType.Int, StateID);
                sqlDbCity.AddInParameter(dbCmdCity, "UserID", SqlDbType.Int, UserID);

                DataTable dtCity = new DataTable();
                using (IDataReader drCity = sqlDbCity.ExecuteReader(dbCmdCity))
                {
                    dtCity.Load(drCity);
                }

                return dtCity;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

    }
}
