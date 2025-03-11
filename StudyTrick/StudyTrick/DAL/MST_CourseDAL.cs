using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_CourseDAL : MST_CourseDALBase
    {
        #region dbo.PR_MST_Course_SelectForDropDown
        public DataTable dbo_PR_MST_Course_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbCourse = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCourse = sqlDbCourse.GetStoredProcCommand("dbo.PR_MST_Course_SelectForDropDown");
                sqlDbCourse.AddInParameter(dbCmdCourse, "UserID", SqlDbType.Int, UserID);

                DataTable dtCourse = new DataTable();
                using (IDataReader drCourse = sqlDbCourse.ExecuteReader(dbCmdCourse))
                {
                    dtCourse.Load(drCourse);
                }

                return dtCourse;
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
