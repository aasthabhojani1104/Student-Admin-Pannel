using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.MST_Qualification.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_QualificationDALBase : DALHelper
    {
        #region dbo.PR_MST_Qualification_SelectAll
        public DataTable dbo_PR_MST_Qualification_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbQualification = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQualification = sqlDbQualification.GetStoredProcCommand("dbo.PR_MST_Qualification_SelectAll");
                sqlDbQualification.AddInParameter(dbCmdQualification, "UserID", SqlDbType.Int, UserID);

                DataTable dtQualification = new DataTable();
                using (IDataReader drQualification = sqlDbQualification.ExecuteReader(dbCmdQualification))
                {
                    dtQualification.Load(drQualification);
                }

                return dtQualification;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Qualification_SelectByPK
        public DataTable dbo_PR_MST_Qualification_SelectByPK(int? QualificationID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbQualification = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQualification = sqlDbQualification.GetStoredProcCommand("dbo.PR_MST_Qualification_SelectByPK");
                sqlDbQualification.AddInParameter(dbCmdQualification, "UserID", SqlDbType.Int, UserID);
                sqlDbQualification.AddInParameter(dbCmdQualification, "QualificationID", SqlDbType.Int, QualificationID);

                DataTable dtQualification = new DataTable();
                using (IDataReader drQualification = sqlDbQualification.ExecuteReader(dbCmdQualification))
                {
                    dtQualification.Load(drQualification);
                }

                return dtQualification;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Qualification_Insert
        public void dbo_PR_MST_Qualification_Insert(MST_QualificationModel modelMST_Qualification, int UserID)
        {
            try
            {
                SqlDatabase sqlDbQualification = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQualification = sqlDbQualification.GetStoredProcCommand("dbo.PR_MST_Qualification_Insert");
                sqlDbQualification.AddInParameter(dbCmdQualification, "UserID", SqlDbType.Int, UserID);
                sqlDbQualification.AddInParameter(dbCmdQualification, "QualificationName", SqlDbType.NVarChar, modelMST_Qualification.QualificationName);
                sqlDbQualification.AddInParameter(dbCmdQualification, "Description", SqlDbType.NVarChar, modelMST_Qualification.Description);
                sqlDbQualification.AddInParameter(dbCmdQualification, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbQualification.AddInParameter(dbCmdQualification, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbQualification.ExecuteNonQuery(dbCmdQualification);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_MST_Qualification_UpdateByPK
        public bool? dbo_PR_MST_Qualification_UpdateByPK(MST_QualificationModel modelMST_Qualification, int UserID)
        {
            try
            {
                SqlDatabase sqlDbQualification = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQualification = sqlDbQualification.GetStoredProcCommand("dbo.PR_MST_Qualification_UpdateByPK");
                sqlDbQualification.AddInParameter(dbCmdQualification, "UserID", SqlDbType.Int, UserID);
                sqlDbQualification.AddInParameter(dbCmdQualification, "QualificationID", SqlDbType.Int, modelMST_Qualification.QualificationID);
                sqlDbQualification.AddInParameter(dbCmdQualification, "QualificationName", SqlDbType.NVarChar, modelMST_Qualification.QualificationName);
                sqlDbQualification.AddInParameter(dbCmdQualification, "Description", SqlDbType.NVarChar, modelMST_Qualification.Description);
                sqlDbQualification.AddInParameter(dbCmdQualification, "ModificationDate", SqlDbType.Date, DBNull.Value);

                int vReturnValue = sqlDbQualification.ExecuteNonQuery(dbCmdQualification);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Qualification_DeleteByPK
        public bool? dbo_PR_MST_Qualification_DeleteByPK(int QualificationID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbQualification = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQualification = sqlDbQualification.GetStoredProcCommand("dbo.PR_MST_Qualification_DeleteByPK");
                sqlDbQualification.AddInParameter(dbCmdQualification, "UserID", SqlDbType.Int, UserID);
                sqlDbQualification.AddInParameter(dbCmdQualification, "QualificationID", SqlDbType.Int, QualificationID);

                int vResultValue = sqlDbQualification.ExecuteNonQuery(dbCmdQualification);

                return (vResultValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}