using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.ADM_Visitor.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class ADM_VisitorDALBase : DALHelper
    {
        #region dbo.PR_ADM_Visitor_SelectAll
        public DataTable dbo_PR_ADM_Visitor_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbVisitor = new SqlDatabase(myConnectionString);
                DbCommand dbCmdVisitor = sqlDbVisitor.GetStoredProcCommand("dbo.PR_ADM_Visitor_SelectAll");
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

        #region dbo.PR_ADM_Visitor_SelectByPK
        public DataTable dbo_PR_ADM_Visitor_SelectByPK(int? VisitorID,int UserID)
        {
            try
            {
                SqlDatabase sqlDbVisitor = new SqlDatabase(myConnectionString);
                DbCommand dbCmdVisitor = sqlDbVisitor.GetStoredProcCommand("dbo.PR_ADM_Visitor_SelectByPK");
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "UserID", SqlDbType.Int, UserID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "VisitorID", SqlDbType.Int, VisitorID);

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

        #region dbo.PR_ADM_Visitor_Insert
        public void dbo_PR_ADM_Visitor_Insert(ADM_VisitorModel modelADM_Visitor, int UserID)
        {
            try
            {
                SqlDatabase sqlDbVisitor = new SqlDatabase(myConnectionString);
                DbCommand dbCmdVisitor = sqlDbVisitor.GetStoredProcCommand("dbo.PR_ADM_Visitor_Insert");
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "UserID", SqlDbType.Int, UserID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "AdmissionYearID", SqlDbType.Int, modelADM_Visitor.AdmissionYearID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "CounsellorStaffID", SqlDbType.Int, modelADM_Visitor.CounsellorStaffID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "VisitorStaffID", SqlDbType.Int, modelADM_Visitor.VisitorStaffID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "StudentName", SqlDbType.NVarChar, modelADM_Visitor.StudentName);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "Phone", SqlDbType.NVarChar, modelADM_Visitor.Phone);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "Email", SqlDbType.NVarChar, modelADM_Visitor.Email);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "NoOfPeople", SqlDbType.Int, modelADM_Visitor.NoOfPeople);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "PassingYear", SqlDbType.Date, modelADM_Visitor.PassingYear);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "Address", SqlDbType.NVarChar, modelADM_Visitor.Address);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "Description", SqlDbType.NVarChar, modelADM_Visitor.Description);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbVisitor.ExecuteNonQuery(dbCmdVisitor);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_ADM_Visitor_UpdateByPK
        public bool? dbo_PR_ADM_Visitor_UpdateByPK(ADM_VisitorModel modelADM_Visitor, int UserID)
        {
            try
            {
                SqlDatabase sqlDbVisitor = new SqlDatabase(myConnectionString);
                DbCommand dbCmdVisitor = sqlDbVisitor.GetStoredProcCommand("dbo.PR_ADM_Visitor_UpdateByPK");
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "UserID", SqlDbType.Int, UserID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "VisitorID", SqlDbType.Int, modelADM_Visitor.VisitorID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "AdmissionYearID", SqlDbType.Int, modelADM_Visitor.AdmissionYearID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "CounsellorStaffID", SqlDbType.Int, modelADM_Visitor.CounsellorStaffID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "VisitorStaffID", SqlDbType.Int, modelADM_Visitor.VisitorStaffID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "StudentName", SqlDbType.NVarChar, modelADM_Visitor.StudentName);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "Phone", SqlDbType.NVarChar, modelADM_Visitor.Phone);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "Email", SqlDbType.NVarChar, modelADM_Visitor.Email);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "NoOfPeople", SqlDbType.Int, modelADM_Visitor.NoOfPeople);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "PassingYear", SqlDbType.Date, modelADM_Visitor.PassingYear);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "Address", SqlDbType.NVarChar, modelADM_Visitor.Address);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "Description", SqlDbType.NVarChar, modelADM_Visitor.Description);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "ModificationDate", SqlDbType.Date, DBNull.Value);

                int vReturnValue = sqlDbVisitor.ExecuteNonQuery(dbCmdVisitor);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_ADM_Visitor_DeleteByPK
        public bool? dbo_PR_ADM_Visitor_DeleteByPK(int VisitorID,int UserID)
        {
            try
            {
                SqlDatabase sqlDbVisitor = new SqlDatabase(myConnectionString);
                DbCommand dbCmdVisitor = sqlDbVisitor.GetStoredProcCommand("dbo.PR_ADM_Visitor_DeleteByPK");
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "UserID", SqlDbType.Int, UserID);
                sqlDbVisitor.AddInParameter(dbCmdVisitor, "VisitorID", SqlDbType.Int, VisitorID);

                int vReturnValue = sqlDbVisitor.ExecuteNonQuery(dbCmdVisitor);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
