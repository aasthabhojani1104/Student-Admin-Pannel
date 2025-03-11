using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.ADM_StudentDocument.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class ADM_StudentDocumentDALBase : DALHelper
    {
        #region dbo.PR_ADM_StudentDocument_SelectAll
        public DataTable dbo_PR_ADM_StudentDocument_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbStudentDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudentDocument = sqlDbStudentDocument.GetStoredProcCommand("dbo.PR_ADM_StudentDocument_SelectAll");
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "UserID", SqlDbType.Int, UserID);

                DataTable dtStudentDocument = new DataTable();
                using (IDataReader drStudentDocument = sqlDbStudentDocument.ExecuteReader(dbCmdStudentDocument))
                {
                    dtStudentDocument.Load(drStudentDocument);
                }

                return dtStudentDocument;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_StudentDocument_SelectByPK
        public DataTable dbo_PR_ADM_StudentDocument_SelectByPK(int? StudentDocumentID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStudentDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudentDocument = sqlDbStudentDocument.GetStoredProcCommand("dbo.PR_ADM_StudentDocument_SelectByPK");
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "StudentDocumentID", SqlDbType.Int, StudentDocumentID);

                DataTable dtStudentDocument = new DataTable();
                using (IDataReader drStudentDocument = sqlDbStudentDocument.ExecuteReader(dbCmdStudentDocument))
                {
                    dtStudentDocument.Load(drStudentDocument);
                }

                return dtStudentDocument;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_StudentDocument_Insert
        public void dbo_PR_ADM_StudentDocument_Insert(ADM_StudentDocumentModel modelADM_StudentDocument, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStudentDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudentDocument = sqlDbStudentDocument.GetStoredProcCommand("dbo.PR_ADM_StudentDocument_Insert");
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "StudentID", SqlDbType.Int, modelADM_StudentDocument.StudentID);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "DocumentID", SqlDbType.Int, modelADM_StudentDocument.DocumentID);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "DocumentPath", SqlDbType.NVarChar, modelADM_StudentDocument.DocumentPath);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "Description", SqlDbType.NVarChar, modelADM_StudentDocument.Description);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbStudentDocument.ExecuteNonQuery(dbCmdStudentDocument);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_ADM_StudentDocument_UpdateByPK
        public bool? dbo_PR_ADM_StudentDocument_UpdateByPK(ADM_StudentDocumentModel modelADM_StudentDocument, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStudentDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudentDocument = sqlDbStudentDocument.GetStoredProcCommand("dbo.PR_ADM_StudentDocument_UpdateByPK");
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "StudentDocumentID", SqlDbType.Int, modelADM_StudentDocument.StudentDocumentID);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "StudentID", SqlDbType.Int, modelADM_StudentDocument.StudentID);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "DocumentID", SqlDbType.Int, modelADM_StudentDocument.DocumentID);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "DocumentPath", SqlDbType.NVarChar, modelADM_StudentDocument.DocumentPath);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "Description", SqlDbType.NVarChar, modelADM_StudentDocument.Description);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "ModificationDate", SqlDbType.Date, DBNull.Value);

                int vReturnValue = sqlDbStudentDocument.ExecuteNonQuery(dbCmdStudentDocument);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_StudentDocument_DeleteByPK
        public bool? dbo_PR_ADM_StudentDocument_DeleteByPK(int StudentDocumentID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStudentDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudentDocument = sqlDbStudentDocument.GetStoredProcCommand("dbo.PR_ADM_StudentDocument_DeleteByPK");
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbStudentDocument.AddInParameter(dbCmdStudentDocument, "StudentDocumentID", SqlDbType.Int, StudentDocumentID);

                int vReturnValue = sqlDbStudentDocument.ExecuteNonQuery(dbCmdStudentDocument);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
