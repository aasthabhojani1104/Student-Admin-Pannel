using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_QuotaDAL : MST_QuotaDALBase
    {
        #region dbo.PR_MST_Quota_SelectForDropDown
        public DataTable dbo_PR_MST_Quota_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbQuota = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQuota = sqlDbQuota.GetStoredProcCommand("dbo.PR_MST_Quota_SelectForDropDown");
                sqlDbQuota.AddInParameter(dbCmdQuota, "UserID", SqlDbType.Int, UserID);

                DataTable dtQuota = new DataTable();
                using (IDataReader drQuota = sqlDbQuota.ExecuteReader(dbCmdQuota))
                {
                    dtQuota.Load(drQuota);
                }

                return dtQuota;
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
