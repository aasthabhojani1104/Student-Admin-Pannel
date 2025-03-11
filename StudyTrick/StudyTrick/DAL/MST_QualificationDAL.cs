using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;

namespace StudyTrick.DAL
{
    public class MST_QualificationDAL : MST_QualificationDALBase
    {
        #region dbo.PR_MST_Qualification_SelectForDropDown
        public DataTable dbo_PR_MST_Qualification_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbQualification = new SqlDatabase(myConnectionString);
                DbCommand dbCmdQualification = sqlDbQualification.GetStoredProcCommand("dbo.PR_MST_Qualification_SelectForDropDown");
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
    }
}
