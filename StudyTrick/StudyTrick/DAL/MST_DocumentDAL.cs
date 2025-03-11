using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_DocumentDAL : MST_DocumentDALBase
    {
        #region dbo.PR_MST_Document_SelectForDropDown
        public DataTable dbo_PR_MST_Document_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbDocument = new SqlDatabase(myConnectionString);
                DbCommand dbCmdDocument = sqlDbDocument.GetStoredProcCommand("dbo.PR_MST_Document_SelectForDropDown");
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
    }
}
