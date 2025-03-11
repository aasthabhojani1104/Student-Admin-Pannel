using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.MST_CourseWiseDocument.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_CourseWiseDocumentDALBase : DALHelper
    {
        #region dbo.PR_MST_CourseWiseDocument_SelectAll
        public DataTable dbo_PR_MST_CourseWiseDocument_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbCourseWiseDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCourseWiseDocument = sqlDbCourseWiseDocument.GetStoredProcCommand("dbo.PR_MST_CourseWiseDocument_SelectAll");
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "UserID", SqlDbType.Int, UserID);

                DataTable dtCourseWiseDocument = new DataTable();
                using (IDataReader drCourseWiseDocument = sqlDbCourseWiseDocument.ExecuteReader(dbCmdCourseWiseDocument))
                {
                    dtCourseWiseDocument.Load(drCourseWiseDocument);
                }

                return dtCourseWiseDocument;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_CourseWiseDocument_SelectByPK
        public DataTable dbo_PR_MST_CourseWiseDocument_SelectByPK(int? CourseWiseDocumentID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCourseWiseDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCourseWiseDocument = sqlDbCourseWiseDocument.GetStoredProcCommand("dbo.PR_MST_CourseWiseDocument_SelectByPK");
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "CourseWiseDocumentID", SqlDbType.Int, CourseWiseDocumentID);

                DataTable dtCourseWiseDocument = new DataTable();
                using (IDataReader drCourseWiseDocument = sqlDbCourseWiseDocument.ExecuteReader(dbCmdCourseWiseDocument))
                {
                    dtCourseWiseDocument.Load(drCourseWiseDocument);
                }

                return dtCourseWiseDocument;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_CourseWiseDocument_Insert
        public void dbo_PR_MST_CourseWiseDocument_Insert(MST_CourseWiseDocumentModel modelMST_CourseWiseDocument, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCourseWiseDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCourseWiseDocument = sqlDbCourseWiseDocument.GetStoredProcCommand("dbo.PR_MST_CourseWiseDocument_Insert");
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "CourseID", SqlDbType.Int, modelMST_CourseWiseDocument.CourseID);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "DocumentID", SqlDbType.Int, modelMST_CourseWiseDocument.DocumentID);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "AdmissionYearID", SqlDbType.Int, modelMST_CourseWiseDocument.AdmissionYearID);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "Description", SqlDbType.NVarChar, modelMST_CourseWiseDocument.Description);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbCourseWiseDocument.ExecuteNonQuery(dbCmdCourseWiseDocument);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_MST_CourseWiseDocument_UpdateByPK
        public bool? dbo_PR_MST_CourseWiseDocument_UpdateByPK(MST_CourseWiseDocumentModel modelMST_CourseWiseDocument, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCourseWiseDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCourseWiseDocument = sqlDbCourseWiseDocument.GetStoredProcCommand("dbo.PR_MST_CourseWiseDocument_UpdateByPK");
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "CourseWiseDocumentID", SqlDbType.Int, modelMST_CourseWiseDocument.CourseWiseDocumentID);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "CourseID", SqlDbType.Int, modelMST_CourseWiseDocument.CourseID);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "DocumentID", SqlDbType.Int, modelMST_CourseWiseDocument.DocumentID);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "AdmissionYearID", SqlDbType.Int, modelMST_CourseWiseDocument.AdmissionYearID);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "Description", SqlDbType.NVarChar, modelMST_CourseWiseDocument.Description);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "ModificationDate", SqlDbType.Date, DBNull.Value);

                int vReturnValue = sqlDbCourseWiseDocument.ExecuteNonQuery(dbCmdCourseWiseDocument);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_CourseWiseDocument_DeleteByPK
        public bool? dbo_PR_MST_CourseWiseDocument_DeleteByPK(int CourseWiseDocumentID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCourseWiseDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCourseWiseDocument = sqlDbCourseWiseDocument.GetStoredProcCommand("dbo.PR_MST_CourseWiseDocument_DeleteByPK");
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbCourseWiseDocument.AddInParameter(dbCmdCourseWiseDocument, "CourseWiseDocumentID", SqlDbType.Int, CourseWiseDocumentID);

                int vReturnValue = sqlDbCourseWiseDocument.ExecuteNonQuery(dbCmdCourseWiseDocument);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
