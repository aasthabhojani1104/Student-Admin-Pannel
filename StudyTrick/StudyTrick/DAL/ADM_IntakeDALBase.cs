using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.ADM_Intake.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class ADM_IntakeDALBase : DALHelper
    {
        #region dbo.PR_ADM_Intake_SelectAll
        public DataTable dbo_PR_ADM_Intake_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbIntake = new SqlDatabase(myConnectionString);
                DbCommand dbCmdIntake = sqlDbIntake.GetStoredProcCommand("dbo.PR_ADM_Intake_SelectAll");
                sqlDbIntake.AddInParameter(dbCmdIntake, "UserID", SqlDbType.Int, UserID);

                DataTable dtIntake = new DataTable();
                using (IDataReader drIntake = sqlDbIntake.ExecuteReader(dbCmdIntake))
                {
                    dtIntake.Load(drIntake);
                }

                return dtIntake;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_Intake_SelectByPK
        public DataTable dbo_PR_ADM_Intake_SelectByPK(int? IntakeID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbIntake = new SqlDatabase(myConnectionString);
                DbCommand dbCmdIntake = sqlDbIntake.GetStoredProcCommand("dbo.PR_ADM_Intake_SelectByPK");
                sqlDbIntake.AddInParameter(dbCmdIntake, "UserID", SqlDbType.Int, UserID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "IntakeID", SqlDbType.Int, IntakeID);

                DataTable dtIntake = new DataTable();
                using (IDataReader drIntake = sqlDbIntake.ExecuteReader(dbCmdIntake))
                {
                    dtIntake.Load(drIntake);
                }

                return dtIntake;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_Intake_Insert
        public void dbo_PR_ADM_Intake_Insert(ADM_IntakeModel modelADM_Intake, int UserID)
        {
            try
            {
                SqlDatabase sqlDbIntake = new SqlDatabase(myConnectionString);
                DbCommand dbCmdIntake = sqlDbIntake.GetStoredProcCommand("dbo.PR_ADM_Intake_Insert");
                sqlDbIntake.AddInParameter(dbCmdIntake, "UserID", SqlDbType.Int, UserID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "CourseID", SqlDbType.Int, modelADM_Intake.CourseID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "ProgramID", SqlDbType.Int, modelADM_Intake.ProgramID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "AdmissionYearID", SqlDbType.Int, modelADM_Intake.AdmissionYearID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "QuotaID", SqlDbType.Int, modelADM_Intake.QuotaID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "Intake", SqlDbType.Int, modelADM_Intake.Intake);
                sqlDbIntake.AddInParameter(dbCmdIntake, "Description", SqlDbType.NVarChar, modelADM_Intake.Description);
                sqlDbIntake.AddInParameter(dbCmdIntake, "CreationDate", SqlDbType.NVarChar, DBNull.Value);
                sqlDbIntake.AddInParameter(dbCmdIntake, "ModificationDate", SqlDbType.NVarChar, DBNull.Value);

                sqlDbIntake.ExecuteNonQuery(dbCmdIntake);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_ADM_Intake_UpdateByPK
        public bool? pr_PR_ADM_Intake_UpdateByPK(ADM_IntakeModel modelADM_Intake, int UserID)
        {
            try
            {
                SqlDatabase sqlDbIntake = new SqlDatabase(myConnectionString);
                DbCommand dbCmdIntake = sqlDbIntake.GetStoredProcCommand("dbo.PR_ADM_Intake_Insert");
                sqlDbIntake.AddInParameter(dbCmdIntake, "UserID", SqlDbType.Int, UserID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "IntakeID", SqlDbType.Int, modelADM_Intake.IntakeID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "CourseID", SqlDbType.Int, modelADM_Intake.CourseID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "ProgramID", SqlDbType.Int, modelADM_Intake.ProgramID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "AdmissionYearID", SqlDbType.Int, modelADM_Intake.AdmissionYearID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "QuotaID", SqlDbType.Int, modelADM_Intake.QuotaID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "Intake", SqlDbType.Int, modelADM_Intake.Intake);
                sqlDbIntake.AddInParameter(dbCmdIntake, "Description", SqlDbType.NVarChar, modelADM_Intake.Description);
                sqlDbIntake.AddInParameter(dbCmdIntake, "ModificationDate", SqlDbType.NVarChar, DBNull.Value);

                int vReturnValue = sqlDbIntake.ExecuteNonQuery(dbCmdIntake);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_Intake_DeleteByPK
        public bool? dbo_PR_ADM_Intake_DeleteByPK(int IntakeID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbIntake = new SqlDatabase(myConnectionString);
                DbCommand dbCmdIntake = sqlDbIntake.GetStoredProcCommand("dbo.PR_ADM_Intake_DeleteByPK");
                sqlDbIntake.AddInParameter(dbCmdIntake, "UserID", SqlDbType.Int, UserID);
                sqlDbIntake.AddInParameter(dbCmdIntake, "IntakeID", SqlDbType.Int, IntakeID);

                int vReturnValue = sqlDbIntake.ExecuteNonQuery(dbCmdIntake);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
