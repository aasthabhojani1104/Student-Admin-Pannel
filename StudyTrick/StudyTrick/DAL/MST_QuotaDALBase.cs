using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.MST_Quota.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_QuotaDALBase : DALHelper
    {
        #region dbo.PR_MST_Quota_SelectAll
        public DataTable dbo_PR_MST_Quota_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbQuota = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQuota = sqlDbQuota.GetStoredProcCommand("dbo.PR_MST_Quota_SelectAll");
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

        #region dbo.PR_MST_Quota_SelectByPK
        public DataTable dbo_PR_MST_Quota_SelectByPK(int? QuotaID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbQuota = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQuota = sqlDbQuota.GetStoredProcCommand("dbo.PR_MST_Quota_SelectByPK");
                sqlDbQuota.AddInParameter(dbCmdQuota, "UserID", SqlDbType.Int, UserID);
                sqlDbQuota.AddInParameter(dbCmdQuota, "QuotaID", SqlDbType.Int, QuotaID);

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

        #region dbo.PR_MST_Quota_Insert
        public void dbo_PR_MST_Quota_Insert(MST_QuotaModel modelMST_Quota, int UserID)
        {
            try
            {
                SqlDatabase sqlDbQuota = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQuota = sqlDbQuota.GetStoredProcCommand("dbo.PR_MST_Quota_Insert");
                sqlDbQuota.AddInParameter(dbCmdQuota, "UserID", SqlDbType.Int, UserID);
                sqlDbQuota.AddInParameter(dbCmdQuota, "CourseID", SqlDbType.Int, modelMST_Quota.CourseID);
                sqlDbQuota.AddInParameter(dbCmdQuota, "QuotaName", SqlDbType.NVarChar, modelMST_Quota.QuotaName);
                sqlDbQuota.AddInParameter(dbCmdQuota, "Description", SqlDbType.NVarChar, modelMST_Quota.Description);
                sqlDbQuota.AddInParameter(dbCmdQuota, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbQuota.AddInParameter(dbCmdQuota, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbQuota.ExecuteNonQuery(dbCmdQuota);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_MST_Quota_UpdateByPK
        public bool? dbo_PR_MST_Quota_UpdateByPK(MST_QuotaModel modelMST_Quota, int UserID)
        {
            try
            {
                SqlDatabase sqlDbQuota = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQuota = sqlDbQuota.GetStoredProcCommand("dbo.PR_MST_Quota_UpdateByPK");
                sqlDbQuota.AddInParameter(dbCmdQuota, "UserID", SqlDbType.Int, UserID);
                sqlDbQuota.AddInParameter(dbCmdQuota, "QuotaID", SqlDbType.Int, modelMST_Quota.QuotaID);
                sqlDbQuota.AddInParameter(dbCmdQuota, "CourseID", SqlDbType.Int, modelMST_Quota.CourseID);
                sqlDbQuota.AddInParameter(dbCmdQuota, "QuotaName", SqlDbType.NVarChar, modelMST_Quota.QuotaName);
                sqlDbQuota.AddInParameter(dbCmdQuota, "Description", SqlDbType.NVarChar, modelMST_Quota.Description);
                sqlDbQuota.AddInParameter(dbCmdQuota, "ModificationDate", SqlDbType.Date, DBNull.Value);

                int vReturnValue = sqlDbQuota.ExecuteNonQuery(dbCmdQuota);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Quota_DeleteByPK
        public bool? dbo_PR_MST_Quota_DeleteByPK(int QuotaID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbQuota = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQuota = sqlDbQuota.GetStoredProcCommand("dbo.PR_MST_Quota_DeleteByPK");
                sqlDbQuota.AddInParameter(dbCmdQuota, "UserID", SqlDbType.Int, UserID);
                sqlDbQuota.AddInParameter(dbCmdQuota, "QuotaID", SqlDbType.Int, QuotaID);

                int vReturnValue = sqlDbQuota.ExecuteNonQuery(dbCmdQuota);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
