using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.MST_AdmissionYear.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_AdmissionYearDALBase : DALHelper
    {
        #region dbo.PR_MST_AdmissionYear_SelectAll
        public DataTable dbo_PR_MST_AdmissionYear_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbAdmissionYear = new SqlDatabase(myConnectionString);
                DbCommand dbCmdAdmissionYear = sqlDbAdmissionYear.GetStoredProcCommand("dbo.PR_MST_AdmissionYear_SelectAll");
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "UserID", SqlDbType.Int, UserID);

                DataTable dtAdmissionYear = new DataTable();
                using (IDataReader drAdmissionYear = sqlDbAdmissionYear.ExecuteReader(dbCmdAdmissionYear))
                {
                    dtAdmissionYear.Load(drAdmissionYear);
                }

                return dtAdmissionYear;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_AdmissionYear_SelectByPK
        public DataTable dbo_PR_MST_AdmissionYear_SelectByPK(int? AdmissionYearID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbAdmissionYear = new SqlDatabase(myConnectionString);
                DbCommand dbCmdAdmissionYear = sqlDbAdmissionYear.GetStoredProcCommand("dbo.PR_MST_AdmissionYear_SelectByPK");
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "UserID", SqlDbType.Int, UserID);
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "AdmissionYearID", SqlDbType.Int, AdmissionYearID);

                DataTable dtAdmissionYear = new DataTable();
                using (IDataReader drAdmissionYear = sqlDbAdmissionYear.ExecuteReader(dbCmdAdmissionYear))
                {
                    dtAdmissionYear.Load(drAdmissionYear);
                }

                return dtAdmissionYear;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region dbo.PR_MST_AdmissionYear_Insert
        public void dbo_PR_MST_AdmissionYear_Insert(MST_AdmissionYearModel modelMST_AdmissionYearModel, int UserID)
        {
            try
            {
                SqlDatabase sqlDbAdmissionYear = new SqlDatabase(myConnectionString);
                DbCommand dbCmdAdmissionYear = sqlDbAdmissionYear.GetStoredProcCommand("dbo.PR_MST_AdmissionYear_Insert");
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "UserID", SqlDbType.Int, UserID);
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "AdmissionYear", SqlDbType.Int, modelMST_AdmissionYearModel.AdmissionYear);
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "Description", SqlDbType.NVarChar, modelMST_AdmissionYearModel.Description);
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbAdmissionYear.ExecuteNonQuery(dbCmdAdmissionYear);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_MST_AdmissionYear_UpdateByPK
        public bool? dbo_PR_MST_AdmissionYear_UpdateByPK(MST_AdmissionYearModel modelAdmissionYearModel, int UserID)
        {
            try
            {
                SqlDatabase sqlDbAdmissionYear = new SqlDatabase(myConnectionString);
                DbCommand dbCmdAdmissionYear = sqlDbAdmissionYear.GetStoredProcCommand("dbo.PR_MST_AdmissionYear_UpdateByPK");
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "UserID", SqlDbType.Int, UserID);
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "AdmissionYearID", SqlDbType.Int, modelAdmissionYearModel.AdmissionYearID);
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "AdmissionYear", SqlDbType.Int, modelAdmissionYearModel.AdmissionYear);
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "Description", SqlDbType.NVarChar, modelAdmissionYearModel.Description);
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "ModificationDate", SqlDbType.NVarChar, DBNull.Value);

                int vReturnValue = sqlDbAdmissionYear.ExecuteNonQuery(dbCmdAdmissionYear);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_AdmissionYear_DeleteByPK
        public bool? dbo_PR_MST_AdmissionYear_DeleteByPK(int AdmissionYearID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbAdmissionYear = new SqlDatabase(myConnectionString);
                DbCommand dbCmdAdmissionYear = sqlDbAdmissionYear.GetStoredProcCommand("dbo.PR_MST_AdmissionYear_DeleteByPK");
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "UserID", SqlDbType.Int, UserID);
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "AdmissionYearID", SqlDbType.Int, AdmissionYearID);

                int vReturnValue = sqlDbAdmissionYear.ExecuteNonQuery(dbCmdAdmissionYear);

                return vReturnValue == -1 ? false : true;
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
