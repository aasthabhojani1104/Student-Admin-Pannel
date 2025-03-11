using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class ADM_VisitorInterestedCoursesDALBase : DALHelper
    {
        #region dbo.PR_ADM_VisitorInterestedCourses_Insert
        public void dbo_PR_ADM_VisitorInterestedCourses_Insert(int UserID, int? VisitorID, int CourseID)
        {
            try
            {
                SqlDatabase sqlDbVisitorInterest = new SqlDatabase(myConnectionString);
                DbCommand dbCmdVisitorInterest = sqlDbVisitorInterest.GetStoredProcCommand("dbo.PR_ADM_VisitorInterestedCourses_Insert");
                sqlDbVisitorInterest.AddInParameter(dbCmdVisitorInterest, "UserID", SqlDbType.Int, UserID);
                sqlDbVisitorInterest.AddInParameter(dbCmdVisitorInterest, "VisitorID", SqlDbType.Int, VisitorID);
                sqlDbVisitorInterest.AddInParameter(dbCmdVisitorInterest, "CourseID", SqlDbType.Int, CourseID);
                sqlDbVisitorInterest.ExecuteNonQuery(dbCmdVisitorInterest);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_ADM_VisitorInterestedCourses_SelectByVisitorID
        public DataTable dbo_PR_ADM_VisitorInterestedCourses_SelectByVisitorID(int UserID, int? VisitorID)
        {
            try
            {
                SqlDatabase sqlDbVisitorInterest = new SqlDatabase(myConnectionString);
                DbCommand dbCmdVisitorInterest = sqlDbVisitorInterest.GetStoredProcCommand("dbo.PR_ADM_VisitorInterestedCourses_SelectByVisitorID");
                sqlDbVisitorInterest.AddInParameter(dbCmdVisitorInterest, "UserID", SqlDbType.Int, UserID);
                sqlDbVisitorInterest.AddInParameter(dbCmdVisitorInterest, "VisitorID", SqlDbType.Int, VisitorID);

                DataTable dtVisitorInterest = new DataTable();
                using (IDataReader drVisitorInterest = sqlDbVisitorInterest.ExecuteReader(dbCmdVisitorInterest))
                {
                    dtVisitorInterest.Load(drVisitorInterest);
                }

                return dtVisitorInterest;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_VisitorInterestedCourses_DeleteByVisitorID
        public bool? dbo_PR_ADM_VisitorInterestedCourses_DeleteByVisitorID(int UserID, int? VisitorID)
        {
            try
            {
                SqlDatabase sqlDbVisitorInterest = new SqlDatabase(myConnectionString);
                DbCommand dbCmdVisitorInterest = sqlDbVisitorInterest.GetStoredProcCommand("dbo.PR_ADM_VisitorInterestedCourses_DeleteByVisitorID");
                sqlDbVisitorInterest.AddInParameter(dbCmdVisitorInterest, "UserID", SqlDbType.Int, UserID);
                sqlDbVisitorInterest.AddInParameter(dbCmdVisitorInterest, "VisitorID", SqlDbType.Int, VisitorID);

                int vReturnValue = sqlDbVisitorInterest.ExecuteNonQuery(dbCmdVisitorInterest);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
