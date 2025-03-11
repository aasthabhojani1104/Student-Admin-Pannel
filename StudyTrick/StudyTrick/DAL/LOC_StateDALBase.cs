using System.Data.Common;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.LOC_State.Models;

namespace StudyTrick.DAL
{
    public class LOC_StateDALBase : DALHelper
    {
        #region dbo.PR_LOC_State_SelectAll
        public DataTable dbo_PR_LOC_State_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbState = new SqlDatabase(myConnectionString);
                DbCommand dbCmd = sqlDbState.GetStoredProcCommand("dbo.PR_LOC_State_SelectAll");
                sqlDbState.AddInParameter(dbCmd, "UserID", SqlDbType.Int, UserID);

                DataTable dt = new DataTable();
                using (IDataReader dr = sqlDbState.ExecuteReader(dbCmd))
                {
                    dt.Load(dr);
                }

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region dbo.PR_LOC_State_SelectByPK
        public DataTable dbo_PR_LOC_State_SelectByPK(int? StateID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbState = new SqlDatabase(myConnectionString);
                DbCommand dbCmdState = sqlDbState.GetStoredProcCommand("dbo.PR_LOC_State_SelectByPK");
                sqlDbState.AddInParameter(dbCmdState, "StateID", SqlDbType.Int, StateID);
                sqlDbState.AddInParameter(dbCmdState, "UserID", SqlDbType.Int, UserID);

                DataTable dt = new DataTable();
                using (IDataReader dr = sqlDbState.ExecuteReader(dbCmdState))
                {
                    dt.Load(dr);
                }

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region dbo.PR_LOC_State_Insert
        public void dbo_PR_LOC_State_Insert(LOC_StateModel modelLOC_State, int UserID)
        {
            try
            {
                SqlDatabase sqlDbState = new SqlDatabase(myConnectionString);
                DbCommand dbCmd = sqlDbState.GetStoredProcCommand("dbo.PR_LOC_State_Insert");
                sqlDbState.AddInParameter(dbCmd, "UserID", SqlDbType.Int, UserID);
                sqlDbState.AddInParameter(dbCmd, "StateName", SqlDbType.NVarChar, modelLOC_State.StateName);
                sqlDbState.AddInParameter(dbCmd, "Description", SqlDbType.NVarChar, modelLOC_State.Description);
                sqlDbState.AddInParameter(dbCmd, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbState.AddInParameter(dbCmd, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbState.ExecuteNonQuery(dbCmd);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_LOC_State_DeleteByPK
        public bool? dbo_PR_LOC_State_DeleteByPK(int StateID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbState = new SqlDatabase(myConnectionString);
                DbCommand dbCmd = sqlDbState.GetStoredProcCommand("dbo.PR_LOC_State_DeleteByPK");
                sqlDbState.AddInParameter(dbCmd, "UserID", SqlDbType.Int, UserID);
                sqlDbState.AddInParameter(dbCmd, "StateID", SqlDbType.Int, StateID);

                int vReturnValue = sqlDbState.ExecuteNonQuery(dbCmd);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region dbo.PR_LOC_State_UpdateByPK
        public bool? dbo_PR_LOC_State_UpdateByPK(LOC_StateModel modelLOC_State, int UserID)
        {
            try
            {
                SqlDatabase sqlDbState = new SqlDatabase(myConnectionString);
                DbCommand dbCmd = sqlDbState.GetStoredProcCommand("dbo.PR_LOC_State_UpdateByPK");
                sqlDbState.AddInParameter(dbCmd, "UserID", SqlDbType.Int, UserID);
                sqlDbState.AddInParameter(dbCmd, "StateID", SqlDbType.Int, modelLOC_State.StateID);
                sqlDbState.AddInParameter(dbCmd, "StateName", SqlDbType.NVarChar, modelLOC_State.StateName);
                sqlDbState.AddInParameter(dbCmd, "Description", SqlDbType.NVarChar, modelLOC_State.Description);
                sqlDbState.AddInParameter(dbCmd, "ModificationDate", SqlDbType.Date, DBNull.Value);

                int vReturnValue = sqlDbState.ExecuteNonQuery(dbCmd);

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
