using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_AdmissionYearDAL : MST_AdmissionYearDALBase
    {
        #region dbo.PR_MST_AdmissionYear_SelectForDropDown
        public DataTable dbo_PR_MST_AdmissionYear_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbAdmissionYear = new SqlDatabase(myConnectionString);
                DbCommand dbCmdAdmissionYear = sqlDbAdmissionYear.GetStoredProcCommand("dbo.PR_MST_AdmissionYear_SelectForDropDown");
                sqlDbAdmissionYear.AddInParameter(dbCmdAdmissionYear, "UserID", SqlDbType.Int, UserID);

                DataTable dtAdmissionYear = new DataTable();
                using (IDataReader drAdmissionYear = sqlDbAdmissionYear.ExecuteReader(dbCmdAdmissionYear))
                {
                    dtAdmissionYear.Load(drAdmissionYear);
                }

                return dtAdmissionYear;
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
