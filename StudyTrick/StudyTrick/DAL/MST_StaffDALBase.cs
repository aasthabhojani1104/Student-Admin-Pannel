using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.MST_Staff.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_StaffDALBase : DALHelper
    {
        #region dbo.PR_MST_Staff_SelectAll
        public DataTable dbo_PR_MST_Staff_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbStaff = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStaff = sqlDbStaff.GetStoredProcCommand("dbo.PR_MST_Staff_SelectAll");
                sqlDbStaff.AddInParameter(dbCmdStaff, "UserID", SqlDbType.Int, UserID);

                DataTable dtStff = new DataTable();
                using (IDataReader drStff = sqlDbStaff.ExecuteReader(dbCmdStaff))
                {
                    dtStff.Load(drStff);
                }

                return dtStff;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Staff_SelectByPK
        public DataTable dbo_PR_MST_Staff_SelectByPK(int? StaffID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStaff = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStaff = sqlDbStaff.GetStoredProcCommand("dbo.PR_MST_Staff_SelectByPK");
                sqlDbStaff.AddInParameter(dbCmdStaff, "UserID", SqlDbType.Int, UserID);
                sqlDbStaff.AddInParameter(dbCmdStaff, "StaffID", SqlDbType.Int, StaffID);

                DataTable dtStff = new DataTable();
                using (IDataReader drStaff = sqlDbStaff.ExecuteReader(dbCmdStaff))
                {
                    dtStff.Load(drStaff);
                }

                return dtStff;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Staff_Insert
        public void dbo_PR_MST_Staff_Insert(MST_StaffModel modelMST_Staff, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStaff = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStaff = sqlDbStaff.GetStoredProcCommand("dbo.PR_MST_Staff_Insert");
                sqlDbStaff.AddInParameter(dbCmdStaff, "UserID", SqlDbType.Int, UserID);
                sqlDbStaff.AddInParameter(dbCmdStaff, "StaffName", SqlDbType.NVarChar, modelMST_Staff.StaffName);
                sqlDbStaff.AddInParameter(dbCmdStaff, "Phone", SqlDbType.NVarChar, modelMST_Staff.Phone);
                sqlDbStaff.AddInParameter(dbCmdStaff, "Email", SqlDbType.NVarChar, modelMST_Staff.Email);
                sqlDbStaff.AddInParameter(dbCmdStaff, "StaffCode", SqlDbType.NVarChar, modelMST_Staff.StaffCode);
                sqlDbStaff.AddInParameter(dbCmdStaff, "Description", SqlDbType.NVarChar, modelMST_Staff.Description);
                sqlDbStaff.AddInParameter(dbCmdStaff, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbStaff.AddInParameter(dbCmdStaff, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbStaff.ExecuteNonQuery(dbCmdStaff);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_MST_Staff_UpdateByPK
        public bool? dbo_PR_MST_Staff_UpdateByPK(MST_StaffModel modelMST_Staff, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStaff = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStaff = sqlDbStaff.GetStoredProcCommand("dbo.PR_MST_Staff_UpdateByPK");
                sqlDbStaff.AddInParameter(dbCmdStaff, "UserID", SqlDbType.Int, UserID);
                sqlDbStaff.AddInParameter(dbCmdStaff, "StaffID", SqlDbType.Int, modelMST_Staff.StaffID);
                sqlDbStaff.AddInParameter(dbCmdStaff, "StaffName", SqlDbType.NVarChar, modelMST_Staff.StaffName);
                sqlDbStaff.AddInParameter(dbCmdStaff, "Phone", SqlDbType.NVarChar, modelMST_Staff.Phone);
                sqlDbStaff.AddInParameter(dbCmdStaff, "Email", SqlDbType.NVarChar, modelMST_Staff.Email);
                sqlDbStaff.AddInParameter(dbCmdStaff, "StaffCode", SqlDbType.NVarChar, modelMST_Staff.StaffCode);
                sqlDbStaff.AddInParameter(dbCmdStaff, "Description", SqlDbType.NVarChar, modelMST_Staff.Description);
                sqlDbStaff.AddInParameter(dbCmdStaff, "ModificationDate", SqlDbType.Date, DBNull.Value);

                int vReturnValue = sqlDbStaff.ExecuteNonQuery(dbCmdStaff);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Staff_DeleteByPK
        public bool? dbo_PR_MST_Staff_DeleteByPK(int StaffID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStaff = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStaff = sqlDbStaff.GetStoredProcCommand("dbo.PR_MST_Staff_DeleteByPK");
                sqlDbStaff.AddInParameter(dbCmdStaff, "UserID", SqlDbType.Int, UserID);
                sqlDbStaff.AddInParameter(dbCmdStaff, "StaffId", SqlDbType.Int, StaffID);

                int vReturnValue = sqlDbStaff.ExecuteNonQuery(dbCmdStaff);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}