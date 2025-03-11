using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.MST_Document.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_DocumentDALBase : DALHelper
    {
        #region dbo.PR_MST_Document_SelectAll
        public DataTable dbo_PR_MST_Document_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdDocument = sqlDbDocument.GetStoredProcCommand("dbo.PR_MST_Document_SelectAll");
                sqlDbDocument.AddInParameter(dbCmdDocument, "UserID", SqlDbType.Int, UserID);

                DataTable dtDocument = new DataTable();
                using (IDataReader drDocument = sqlDbDocument.ExecuteReader(dbCmdDocument))
                {
                    dtDocument.Load(drDocument);
                }

                return dtDocument;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Document_SelectByPK
        public DataTable dbo_PR_MST_Document_SelectByPK(int? DocumentID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdDocument = sqlDbDocument.GetStoredProcCommand("dbo.PR_MST_Document_SelectByPK");
                sqlDbDocument.AddInParameter(dbCmdDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbDocument.AddInParameter(dbCmdDocument, "DocumentID", SqlDbType.Int, DocumentID);

                DataTable dtDocument = new DataTable();
                using (IDataReader drDocument = sqlDbDocument.ExecuteReader(dbCmdDocument))
                {
                    dtDocument.Load(drDocument);
                }

                return dtDocument;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Document_Insert
        public void dbo_PR_MST_Document_Insert(MST_DocumentModel modelMST_Document, int UserID)
        {
            try
            {
                SqlDatabase sqlDbDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdDocument = sqlDbDocument.GetStoredProcCommand("dbo.PR_MST_Document_Insert");
                sqlDbDocument.AddInParameter(dbCmdDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbDocument.AddInParameter(dbCmdDocument, "DocumentName", SqlDbType.NVarChar, modelMST_Document.DocumentName);
                sqlDbDocument.AddInParameter(dbCmdDocument, "Description", SqlDbType.NVarChar, modelMST_Document.Description);
                sqlDbDocument.AddInParameter(dbCmdDocument, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbDocument.AddInParameter(dbCmdDocument, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbDocument.ExecuteNonQuery(dbCmdDocument);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_MST_Document_UpdateByPK
        public bool? dbo_PR_MST_Document_UpdateByPK(MST_DocumentModel modelMST_Document, int UserID)
        {
            try
            {
                SqlDatabase sqlDbDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdDocument = sqlDbDocument.GetStoredProcCommand("dbo.PR_MST_Document_UpdateByPK");
                sqlDbDocument.AddInParameter(dbCmdDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbDocument.AddInParameter(dbCmdDocument, "DocumentID", SqlDbType.Int, modelMST_Document.DocumentID);
                sqlDbDocument.AddInParameter(dbCmdDocument, "DocumentName", SqlDbType.NVarChar, modelMST_Document.DocumentName);
                sqlDbDocument.AddInParameter(dbCmdDocument, "Description", SqlDbType.NVarChar, modelMST_Document.Description);
                sqlDbDocument.AddInParameter(dbCmdDocument, "ModificationDate", SqlDbType.Date, DBNull.Value);

                int vReturnValue = sqlDbDocument.ExecuteNonQuery(dbCmdDocument);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Document_DeleteByPK
        public bool? dbo_PR_MST_Document_DeleteByPK(int DocumentID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdDocument = sqlDbDocument.GetStoredProcCommand("dbo.PR_MST_Document_DeleteByPK");
                sqlDbDocument.AddInParameter(dbCmdDocument, "UserID", SqlDbType.Int, UserID);
                sqlDbDocument.AddInParameter(dbCmdDocument, "DocumentID", SqlDbType.Int, DocumentID);

                int vRetunValue = sqlDbDocument.ExecuteNonQuery(dbCmdDocument);

                return (vRetunValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
