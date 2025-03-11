using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class ADM_VisitorDAL : ADM_VisitorDALBase
    {
        #region dbo.PR_ADM_Visitor_SelectForDropDown
        public DataTable dbo_PR_ADM_Visitor_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbVisitor = new SqlDatabase(myConnectionString);
                DbCommand dbCmdVisitor = sqlDbVisitor.GetStoredProcCommand("dbo.PR_ADM_Visitor_SelectForDropDown");
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "UserID", SqlDbType.Int, UserID);

                DataTable dtVisitor = new DataTable();
                using (IDataReader drVisitor = sqlDbVisitor.ExecuteReader(dbCmdVisitor))
                {
                    dtVisitor.Load(drVisitor);
                }

                return dtVisitor;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_Visitor_SelectByStaff
        public DataTable dbo_PR_ADM_Visitor_SelectByStaff(int UserID,int StaffID)
        {
            try
            {
                SqlDatabase sqlDbVisitor = new SqlDatabase(myConnectionString);
                DbCommand dbCmdVisitor = sqlDbVisitor.GetStoredProcCommand("dbo.PR_ADM_Visitor_SelectByStaff");
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "UserID", SqlDbType.Int, UserID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "StaffID", SqlDbType.Int, StaffID);

                DataTable dtVisitor = new DataTable();
                using (IDataReader drVisitor = sqlDbVisitor.ExecuteReader(dbCmdVisitor))
                {
                    dtVisitor.Load(drVisitor);
                }

                return dtVisitor;
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
