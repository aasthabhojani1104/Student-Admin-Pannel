using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.ADM_Student.Models;
using System.Data.Common;
using System.Data;

namespace StudyTrick.DAL
{
    public class ADM_StudentDALBase : DALHelper
    {
        #region dbo.PR_ADM_Student_SelectAll
        public DataTable dbo_PR_ADM_Student_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbStudent = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudent = sqlDbStudent.GetStoredProcCommand("dbo.PR_ADM_Student_SelectAll");
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

        #region dbo.PR_ADM_Student_SelectByPK
        public DataTable dbo_PR_ADM_Student_SelectByPK(int? StudentID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStudent = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudent = sqlDbStudent.GetStoredProcCommand("dbo.PR_ADM_Student_SelectByPK");
                sqlDbStudent.AddInParameter(dbCmdStudent, "UserID", SqlDbType.Int, UserID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "StudentID", SqlDbType.Int, StudentID);

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

        #region dbo.PR_ADM_Student_Insert
        public void dbo_PR_ADM_Student_Insert(ADM_StudentModel modelADM_Student, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStudent = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudent = sqlDbStudent.GetStoredProcCommand("dbo.PR_ADM_Student_Insert");
                sqlDbStudent.AddInParameter(dbCmdStudent, "UserID", SqlDbType.Int, UserID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "VisitorID", SqlDbType.Int, modelADM_Student.VisitorID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "AdmissionYearID", SqlDbType.Int, modelADM_Student.AdmissionYearID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "QuotaID", SqlDbType.Int, modelADM_Student.QuotaID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "CourseID", SqlDbType.Int, modelADM_Student.CourseID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "ProgramID", SqlDbType.Int, modelADM_Student.ProgramID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "QualificationID", SqlDbType.Int, modelADM_Student.QualificationID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "CasteCategoryID", SqlDbType.Int, modelADM_Student.CasteCategoryID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "StateID", SqlDbType.Int, modelADM_Student.StateID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "CityID", SqlDbType.Int, modelADM_Student.CityID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "ParentPhone", SqlDbType.NVarChar, modelADM_Student.ParentPhone);
                sqlDbStudent.AddInParameter(dbCmdStudent, "Gender", SqlDbType.NVarChar, modelADM_Student.Gender);
                sqlDbStudent.AddInParameter(dbCmdStudent, "DateOfBirth", SqlDbType.DateTime, modelADM_Student.DateOfBirth);
                sqlDbStudent.AddInParameter(dbCmdStudent, "SSCPercentage", SqlDbType.Decimal, modelADM_Student.SSCPercentage);
                sqlDbStudent.AddInParameter(dbCmdStudent, "SSCSchoolName", SqlDbType.NVarChar, modelADM_Student.SSCSchoolName);
                sqlDbStudent.AddInParameter(dbCmdStudent, "SSCPassingYear", SqlDbType.Int, modelADM_Student.SSCPassingYear);
                sqlDbStudent.AddInParameter(dbCmdStudent, "HSCPercentage", SqlDbType.Decimal, modelADM_Student.HSCPercentage);
                sqlDbStudent.AddInParameter(dbCmdStudent, "HSCSchoolName", SqlDbType.NVarChar, modelADM_Student.HSCSchoolName);
                sqlDbStudent.AddInParameter(dbCmdStudent, "HSCPassingYear", SqlDbType.Int, modelADM_Student.HSCPassingYear);
                sqlDbStudent.AddInParameter(dbCmdStudent, "DiplomaPercentage", SqlDbType.Decimal, modelADM_Student.DiplomaPercentage);
                sqlDbStudent.AddInParameter(dbCmdStudent, "DiplomaCollegeName", SqlDbType.NVarChar, modelADM_Student.DiplomaCollegeName);
                sqlDbStudent.AddInParameter(dbCmdStudent, "DiplomaPassingYear", SqlDbType.Int, modelADM_Student.DiplomaPassingYear);
                sqlDbStudent.AddInParameter(dbCmdStudent, "UGPercentage", SqlDbType.Decimal, modelADM_Student.UGPercentage);
                sqlDbStudent.AddInParameter(dbCmdStudent, "UGCollegeName", SqlDbType.NVarChar, modelADM_Student.UGCollegeName);
                sqlDbStudent.AddInParameter(dbCmdStudent, "UGPassingYear", SqlDbType.Int, modelADM_Student.UGPassingYear);
                sqlDbStudent.AddInParameter(dbCmdStudent, "PGPercentage", SqlDbType.Decimal, modelADM_Student.PGPercentage);
                sqlDbStudent.AddInParameter(dbCmdStudent, "PGCollegeName", SqlDbType.NVarChar, modelADM_Student.PGCollegeName);
                sqlDbStudent.AddInParameter(dbCmdStudent, "PGPassingYear", SqlDbType.Int, modelADM_Student.PGPassingYear);
                sqlDbStudent.AddInParameter(dbCmdStudent, "PhotoPath", SqlDbType.NVarChar, modelADM_Student.PhotoPath);
                sqlDbStudent.AddInParameter(dbCmdStudent, "Description", SqlDbType.NVarChar, modelADM_Student.Description);
                sqlDbStudent.AddInParameter(dbCmdStudent, "CreationDate", SqlDbType.NVarChar, DBNull.Value);
                sqlDbStudent.AddInParameter(dbCmdStudent, "ModificationDate", SqlDbType.NVarChar, DBNull.Value);

                sqlDbStudent.ExecuteNonQuery(dbCmdStudent);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_ADM_Student_UpdateByPK
        public bool? dbo_PR_ADM_Student_UpdateByPK(ADM_StudentModel modelADM_Student, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStudent = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudent = sqlDbStudent.GetStoredProcCommand("dbo.PR_ADM_Student_UpdateByPK");
                sqlDbStudent.AddInParameter(dbCmdStudent, "UserID", SqlDbType.Int, UserID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "StudentID", SqlDbType.Int, modelADM_Student.StudentID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "VisitorID", SqlDbType.Int, modelADM_Student.VisitorID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "AdmissionYearID", SqlDbType.Int, modelADM_Student.AdmissionYearID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "QuotaID", SqlDbType.Int, modelADM_Student.QuotaID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "CourseID", SqlDbType.Int, modelADM_Student.CourseID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "ProgramID", SqlDbType.Int, modelADM_Student.ProgramID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "QualificationID", SqlDbType.Int, modelADM_Student.QualificationID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "CasteCategoryID", SqlDbType.Int, modelADM_Student.CasteCategoryID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "StateID", SqlDbType.Int, modelADM_Student.StateID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "CityID", SqlDbType.Int, modelADM_Student.CityID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "ParentPhone", SqlDbType.NVarChar, modelADM_Student.ParentPhone);
                sqlDbStudent.AddInParameter(dbCmdStudent, "Gender", SqlDbType.NVarChar, modelADM_Student.Gender);
                sqlDbStudent.AddInParameter(dbCmdStudent, "DateOfBirth", SqlDbType.DateTime, modelADM_Student.DateOfBirth);
                sqlDbStudent.AddInParameter(dbCmdStudent, "SSCPercentage", SqlDbType.Decimal, modelADM_Student.SSCPercentage);
                sqlDbStudent.AddInParameter(dbCmdStudent, "SSCSchoolName", SqlDbType.NVarChar, modelADM_Student.SSCSchoolName);
                sqlDbStudent.AddInParameter(dbCmdStudent, "SSCPassingYear", SqlDbType.Int, modelADM_Student.SSCPassingYear);
                sqlDbStudent.AddInParameter(dbCmdStudent, "HSCPercentage", SqlDbType.Decimal, modelADM_Student.HSCPercentage);
                sqlDbStudent.AddInParameter(dbCmdStudent, "HSCSchoolName", SqlDbType.NVarChar, modelADM_Student.HSCSchoolName);
                sqlDbStudent.AddInParameter(dbCmdStudent, "HSCPassingYear", SqlDbType.Int, modelADM_Student.HSCPassingYear);
                sqlDbStudent.AddInParameter(dbCmdStudent, "DiplomaPercentage", SqlDbType.Decimal, modelADM_Student.DiplomaPercentage);
                sqlDbStudent.AddInParameter(dbCmdStudent, "DiplomaCollegeName", SqlDbType.NVarChar, modelADM_Student.DiplomaCollegeName);
                sqlDbStudent.AddInParameter(dbCmdStudent, "DiplomaPassingYear", SqlDbType.Int, modelADM_Student.DiplomaPassingYear);
                sqlDbStudent.AddInParameter(dbCmdStudent, "UGPercentage", SqlDbType.Decimal, modelADM_Student.UGPercentage);
                sqlDbStudent.AddInParameter(dbCmdStudent, "UGCollegeName", SqlDbType.NVarChar, modelADM_Student.UGCollegeName);
                sqlDbStudent.AddInParameter(dbCmdStudent, "UGPassingYear", SqlDbType.Int, modelADM_Student.UGPassingYear);
                sqlDbStudent.AddInParameter(dbCmdStudent, "PGPercentage", SqlDbType.Decimal, modelADM_Student.PGPercentage);
                sqlDbStudent.AddInParameter(dbCmdStudent, "PGCollegeName", SqlDbType.NVarChar, modelADM_Student.PGCollegeName);
                sqlDbStudent.AddInParameter(dbCmdStudent, "PGPassingYear", SqlDbType.Int, modelADM_Student.PGPassingYear);
                sqlDbStudent.AddInParameter(dbCmdStudent, "PhotoPath", SqlDbType.NVarChar, modelADM_Student.PhotoPath);
                sqlDbStudent.AddInParameter(dbCmdStudent, "Description", SqlDbType.NVarChar, modelADM_Student.Description);
                sqlDbStudent.AddInParameter(dbCmdStudent, "ModificationDate", SqlDbType.NVarChar, DBNull.Value);

                int vReturnValue = sqlDbStudent.ExecuteNonQuery(dbCmdStudent);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_Student_DeleteByPK
        public bool? dbo_PR_ADM_Student_DeleteByPK(int StudentID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbStudent = new SqlDatabase(myConnectionString);
                DbCommand dbCmdStudent = sqlDbStudent.GetStoredProcCommand("dbo.PR_ADM_Student_DeleteByPK");
                sqlDbStudent.AddInParameter(dbCmdStudent, "UserID", SqlDbType.Int, UserID);
                sqlDbStudent.AddInParameter(dbCmdStudent, "StudentID", SqlDbType.Int, StudentID);

                int vReturnValue = sqlDbStudent.ExecuteNonQuery(dbCmdStudent);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

    }
}
