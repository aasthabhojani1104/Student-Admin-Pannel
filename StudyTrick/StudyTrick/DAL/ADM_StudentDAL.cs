using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class ADM_StudentDAL : ADM_StudentDALBase
    {
        #region dbo.PR_ADM_Student_SelectForDropDown
        public DataTable dbo_PR_ADM_Student_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbStudent = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudent = sqlDbStudent.GetStoredProcCommand("dbo.PR_ADM_Student_SelectForDropDown");
                sqlDbStudent.AddInParameter(dbCmdStudent, "UserID", SqlDbType.Int, UserID);

                DataTable dtStudent = new DataTable();
                using (IDataReader drStudent = sqlDbStudent.ExecuteReader(dbCmdStudent))
                {
                    dtStudent.Load(drStudent);
                }

                return dtStudent;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_Student_SelectByGender
        public DataTable dbo_PR_ADM_Student_SelectByGender(int UserID, string Gender)
        {
            try
            {
                SqlDatabase sqlDbStudent = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudent = sqlDbStudent.GetStoredProcCommand("dbo.PR_ADM_Student_SelectByGender");
                sqlDbStudent.AddInParameter(dbCmdStudent, "UserID", SqlDbType.Int, UserID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "Gender", SqlDbType.NVarChar, Gender);

                DataTable dtStudent = new DataTable();
                using (IDataReader drStudent = sqlDbStudent.ExecuteReader(dbCmdStudent))
                {
                    dtStudent.Load(drStudent);
                }

                return dtStudent;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_Student_SelectByAdmissionYear
        public DataTable dbo_PR_ADM_Student_SelectByAdmissionYear(int UserID, int AdmissionYearID)
        {
            try
            {
                SqlDatabase sqlDbStudent = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudent = sqlDbStudent.GetStoredProcCommand("dbo.PR_ADM_Student_SelectByAdmissionYear");
                sqlDbStudent.AddInParameter(dbCmdStudent, "UserID", SqlDbType.Int, UserID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "AdmissionYearID", SqlDbType.Int, AdmissionYearID);

                DataTable dtStudent = new DataTable();
                using (IDataReader drStudent = sqlDbStudent.ExecuteReader(dbCmdStudent))
                {
                    dtStudent.Load(drStudent);
                }

                return dtStudent;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_Student_SelectByCourseID
        public DataTable dbo_PR_ADM_Student_SelectByCourseID(int UserID, int CourseID)
        {
            try
            {
                SqlDatabase sqlDbStudent = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudent = sqlDbStudent.GetStoredProcCommand("dbo.PR_ADM_Student_SelectByCourseID");
                sqlDbStudent.AddInParameter(dbCmdStudent, "UserID", SqlDbType.Int, UserID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "CourseID", SqlDbType.Int, CourseID);

                DataTable dtStudent = new DataTable();
                using (IDataReader drStudent = sqlDbStudent.ExecuteReader(dbCmdStudent))
                {
                    dtStudent.Load(drStudent);
                }

                return dtStudent;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_Student_SelectByStateID
        public DataTable dbo_PR_ADM_Student_SelectByStateID(int UserID, int StateID)
        {
            try
            {
                SqlDatabase sqlDbStudent = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudent = sqlDbStudent.GetStoredProcCommand("dbo.PR_ADM_Student_SelectByStateID");
                sqlDbStudent.AddInParameter(dbCmdStudent, "UserID", SqlDbType.Int, UserID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "StateID", SqlDbType.Int, StateID);

                DataTable dtStudent = new DataTable();
                using (IDataReader drStudent = sqlDbStudent.ExecuteReader(dbCmdStudent))
                {
                    dtStudent.Load(drStudent);
                }

                return dtStudent;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_Student_SelectByCityID
        public DataTable dbo_PR_ADM_Student_SelectByCityID(int UserID, int CityID)
        {
            try
            {
                SqlDatabase sqlDbStudent = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudent = sqlDbStudent.GetStoredProcCommand("dbo.PR_ADM_Student_SelectByCityID");
                sqlDbStudent.AddInParameter(dbCmdStudent, "UserID", SqlDbType.Int, UserID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "CityID", SqlDbType.Int, CityID);

                DataTable dtStudent = new DataTable();
                using (IDataReader drStudent = sqlDbStudent.ExecuteReader(dbCmdStudent))
                {
                    dtStudent.Load(drStudent);
                }

                return dtStudent;
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
