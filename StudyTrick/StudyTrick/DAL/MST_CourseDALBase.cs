using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.MST_Course.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_CourseDALBase : DALHelper
    {
        #region dbo.PR_MST_Course_SelectAll
        public DataTable dbo_PR_MST_Course_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbCourse = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCourse = sqlDbCourse.GetStoredProcCommand("dbo.PR_MST_Course_SelectAll");
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

        #region dbo.PR_MST_Course_SelectByPK
        public DataTable dbo_PR_MST_Course_SelectByPK(int? CourseID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCourse = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCourse = sqlDbCourse.GetStoredProcCommand("dbo.PR_MST_Course_SelectByPK");
                sqlDbCourse.AddInParameter(dbCmdCourse, "UserID", SqlDbType.Int, UserID);
                sqlDbCourse.AddInParameter(dbCmdCourse, "CourseID", SqlDbType.Int, CourseID);

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

        #region dbo.PR_MST_Course_Insert
        public void dbo_PR_MST_Course_Insert(MST_CourseModel modelMST_Course, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCourse = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCourse = sqlDbCourse.GetStoredProcCommand("dbo.PR_MST_Course_Insert");
                sqlDbCourse.AddInParameter(dbCmdCourse, "UserID", SqlDbType.Int, UserID);
                sqlDbCourse.AddInParameter(dbCmdCourse, "CourseName", SqlDbType.NVarChar, modelMST_Course.CourseName);
                sqlDbCourse.AddInParameter(dbCmdCourse, "CourseLevel", SqlDbType.NVarChar, modelMST_Course.CourseLevel);
                sqlDbCourse.AddInParameter(dbCmdCourse, "CourseDuration", SqlDbType.NVarChar, modelMST_Course.CourseDuration);
                sqlDbCourse.AddInParameter(dbCmdCourse, "Description", SqlDbType.NVarChar, modelMST_Course.Description);
                sqlDbCourse.AddInParameter(dbCmdCourse, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbCourse.AddInParameter(dbCmdCourse, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbCourse.ExecuteNonQuery(dbCmdCourse);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_MST_Course_UpdateByPK
        public bool? dbo_PR_MST_Course_UpdateByPK(MST_CourseModel modelMST_Course, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCourse = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCourse = sqlDbCourse.GetStoredProcCommand("dbo.PR_MST_Course_UpdateByPK");
                sqlDbCourse.AddInParameter(dbCmdCourse, "UserID", SqlDbType.Int, UserID);
                sqlDbCourse.AddInParameter(dbCmdCourse, "CourseID", SqlDbType.Int, modelMST_Course.CourseID);
                sqlDbCourse.AddInParameter(dbCmdCourse, "CourseName", SqlDbType.NVarChar, modelMST_Course.CourseName);
                sqlDbCourse.AddInParameter(dbCmdCourse, "CourseLevel", SqlDbType.NVarChar, modelMST_Course.CourseLevel);
                sqlDbCourse.AddInParameter(dbCmdCourse, "CourseDuration", SqlDbType.NVarChar, modelMST_Course.CourseDuration);
                sqlDbCourse.AddInParameter(dbCmdCourse, "Description", SqlDbType.NVarChar, modelMST_Course.Description);
                sqlDbCourse.AddInParameter(dbCmdCourse, "ModificationDate", SqlDbType.Int, DBNull.Value);

                int vReturnValue = sqlDbCourse.ExecuteNonQuery(dbCmdCourse);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Course_DeleteByPK
        public bool? dbo_PR_MST_Course_DeleteByPK(int CourseID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCourse = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCourse = sqlDbCourse.GetStoredProcCommand("dbo.PR_MST_Course_DeleteByPK");
                sqlDbCourse.AddInParameter(dbCmdCourse, "USerID", SqlDbType.Int, UserID);
                sqlDbCourse.AddInParameter(dbCmdCourse, "CourseID", SqlDbType.Int, CourseID);

                int vReturnValue = sqlDbCourse.ExecuteNonQuery(dbCmdCourse);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
