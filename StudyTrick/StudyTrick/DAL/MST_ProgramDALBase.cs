using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.MST_Program.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_ProgramDALBase : DALHelper
    {
        #region dbo.PR_MST_Program_SelectAll
        public DataTable dbo_PR_MST_Program_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbProgram = new SqlDatabase(myConnectionString);
                DbCommand dbCmdProgram = sqlDbProgram.GetStoredProcCommand("dbo.PR_MST_Program_SelectAll");
                sqlDbProgram.AddInParameter(dbCmdProgram, "UserID", SqlDbType.Int, UserID);

                DataTable dtProgram = new DataTable();
                using (IDataReader drProgram = sqlDbProgram.ExecuteReader(dbCmdProgram))
                {
                    dtProgram.Load(drProgram);
                }

                return dtProgram;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Program_SelectByPK
        public DataTable dbo_PR_MST_Program_SelectByPK(int? ProgramID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbProgram = new SqlDatabase(myConnectionString);
                DbCommand dbCmdProgram = sqlDbProgram.GetStoredProcCommand("dbo.PR_MST_Program_SelectByPK");
                sqlDbProgram.AddInParameter(dbCmdProgram, "UserID", SqlDbType.Int, UserID);
                sqlDbProgram.AddInParameter(dbCmdProgram, "ProgramID", SqlDbType.Int, ProgramID);

                DataTable dtProgram = new DataTable();
                using (IDataReader drProgram = sqlDbProgram.ExecuteReader(dbCmdProgram))
                {
                    dtProgram.Load(drProgram);
                }

                return dtProgram;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Program_Insert
        public void dbo_PR_MST_Program_Insert(MST_ProgramModel modelMST_Program, int UserID)
        {
            try
            {
                SqlDatabase sqlDbProgram = new SqlDatabase(myConnectionString);
                DbCommand dbCmdProgram = sqlDbProgram.GetStoredProcCommand("dbo.PR_MST_Program_Insert");
                sqlDbProgram.AddInParameter(dbCmdProgram, "UserID", SqlDbType.Int, UserID);
                sqlDbProgram.AddInParameter(dbCmdProgram, "CourseID", SqlDbType.Int, modelMST_Program.CourseID);
                sqlDbProgram.AddInParameter(dbCmdProgram, "ProgramName", SqlDbType.NVarChar, modelMST_Program.ProgramName);
                sqlDbProgram.AddInParameter(dbCmdProgram, "Description", SqlDbType.NVarChar, modelMST_Program.Description);
                sqlDbProgram.AddInParameter(dbCmdProgram, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbProgram.AddInParameter(dbCmdProgram, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbProgram.ExecuteNonQuery(dbCmdProgram);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_MST_Program_UpdateByPK
        public bool? dbo_PR_MST_Program_UpdateByPK(MST_ProgramModel modelMST_Program, int UserID)
        {
            try
            {
                SqlDatabase sqlDbProgram = new SqlDatabase(myConnectionString);
                DbCommand dbCmdProgram = sqlDbProgram.GetStoredProcCommand("dbo.PR_MST_Program_UpdateByPK");
                sqlDbProgram.AddInParameter(dbCmdProgram, "UserID", SqlDbType.Int, UserID);
                sqlDbProgram.AddInParameter(dbCmdProgram, "ProgramID", SqlDbType.Int, modelMST_Program.ProgramID);
                sqlDbProgram.AddInParameter(dbCmdProgram, "CourseID", SqlDbType.Int, modelMST_Program.CourseID);
                sqlDbProgram.AddInParameter(dbCmdProgram, "ProgramName", SqlDbType.NVarChar, modelMST_Program.ProgramName);
                sqlDbProgram.AddInParameter(dbCmdProgram, "Description", SqlDbType.NVarChar, modelMST_Program.Description);
                sqlDbProgram.AddInParameter(dbCmdProgram, "ModificationDate", SqlDbType.Date, DBNull.Value);

                int vReturnValue = sqlDbProgram.ExecuteNonQuery(dbCmdProgram);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Program_DeleteByPK
        public bool? dbo_PR_MST_Program_DeleteByPK(int ProgramID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbProgram = new SqlDatabase(myConnectionString);
                DbCommand dbCmdProgram = sqlDbProgram.GetStoredProcCommand("dbo.PR_MST_Program_DeleteByPK");
                sqlDbProgram.AddInParameter(dbCmdProgram, "UserID", SqlDbType.Int, UserID);
                sqlDbProgram.AddInParameter(dbCmdProgram, "ProgramID", SqlDbType.Int, ProgramID);

                int vReturnValue = sqlDbProgram.ExecuteNonQuery(dbCmdProgram);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
