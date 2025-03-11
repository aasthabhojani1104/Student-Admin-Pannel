using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;

namespace StudyTrick.DAL
{
    public class MST_StaffDAL : MST_StaffDALBase
    {
        #region dbo.PR_MST_Staff_SelectForDropDown
        public DataTable dbo_PR_MST_Staff_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbStaff = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStaff = sqlDbStaff.GetStoredProcCommand("dbo.PR_MST_Staff_SelectForDropDown");
                sqlDbStaff.AddInParameter(dbCmdStaff, "UserID", SqlDbType.Int, UserID);

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
    }
}
