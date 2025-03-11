using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.LOC_City.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class LOC_CityDALBase : DALHelper
    {
        #region dbo.PR_LOC_City_SelectAll
        public DataTable dbo_PR_LOC_City_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbCity = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCity = sqlDbCity.GetStoredProcCommand("dbo.PR_LOC_City_SelectAll");
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

        #region dbo.PR_LOC_City_Insert
        public void dbo_PR_LOC_City_Insert(LOC_CityModel modelLOC_City,int UserID)
        {
            try
            {
                SqlDatabase sqlDbCity = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCity = sqlDbCity.GetStoredProcCommand("dbo.PR_LOC_City_Insert");
                sqlDbCity.AddInParameter(dbCmdCity, "UserID", SqlDbType.Int, UserID);
                sqlDbCity.AddInParameter(dbCmdCity, "StateID", SqlDbType.Int, modelLOC_City.StateID);
                sqlDbCity.AddInParameter(dbCmdCity, "CityName", SqlDbType.NVarChar, modelLOC_City.CityName);
                sqlDbCity.AddInParameter(dbCmdCity, "Description", SqlDbType.NVarChar, modelLOC_City.Description);
                sqlDbCity.AddInParameter(dbCmdCity, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbCity.AddInParameter(dbCmdCity, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbCity.ExecuteNonQuery(dbCmdCity);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_LOC_City_SelectByPK
        public DataTable dbo_PR_LOC_City_SelectByPK(int? CityID,int UserID)
        {
            try
            {
                SqlDatabase sqlDbCity = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCity = sqlDbCity.GetStoredProcCommand("dbo.PR_LOC_City_SelectByPK");
                sqlDbCity.AddInParameter(dbCmdCity, "UserID", SqlDbType.Int, UserID);
                sqlDbCity.AddInParameter(dbCmdCity, "CityID", SqlDbType.Int, CityID);

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

        #region dbo.PR_LOC_City_UpdateByPK
        public bool? dbo_PR_LOC_City_UpdateByPK(LOC_CityModel modelLOC_City, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCity = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCity = sqlDbCity.GetStoredProcCommand("dbo.PR_LOC_City_UpdateByPK");
                sqlDbCity.AddInParameter(dbCmdCity, "UserID", SqlDbType.Int, UserID);
                sqlDbCity.AddInParameter(dbCmdCity, "StateID", SqlDbType.Int, modelLOC_City.StateID);
                sqlDbCity.AddInParameter(dbCmdCity, "CityID", SqlDbType.Int, modelLOC_City.CityID);
                sqlDbCity.AddInParameter(dbCmdCity, "CityName", SqlDbType.NVarChar, modelLOC_City.CityName);
                sqlDbCity.AddInParameter(dbCmdCity, "Description", SqlDbType.NVarChar, modelLOC_City.Description);
                sqlDbCity.AddInParameter(dbCmdCity, "ModificationDate", SqlDbType.Date, DBNull.Value);

                int vReturnValue = sqlDbCity.ExecuteNonQuery(dbCmdCity);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_LOC_City_DeleteByPK
        public bool? dbo_PR_LOC_City_DeleteByPK(int CityID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCity = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCity = sqlDbCity.GetStoredProcCommand("dbo.PR_LOC_City_DeleteByPK");
                sqlDbCity.AddInParameter(dbCmdCity, "UserID", SqlDbType.Int, UserID);
                sqlDbCity.AddInParameter(dbCmdCity, "CityID", SqlDbType.Int, CityID);
                int vReturnValue = sqlDbCity.ExecuteNonQuery(dbCmdCity);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}
