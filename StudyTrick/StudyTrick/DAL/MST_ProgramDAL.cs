using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_ProgramDAL : MST_ProgramDALBase
    {
        #region dbo.PR_MST_Program_SelectForDropDown
        public DataTable dbo_PR_MST_Program_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbProgram = new SqlDatabase(myConnectionString);
                DbCommand dbCmdProgram = sqlDbProgram.GetStoredProcCommand("dbo.PR_MST_Program_SelectForDropDown");
                sqlDbProgram.AddInParameter(dbCmdProgram, "UserID", SqlDbType.Int, UserID);

                DataTable dtProgram = new DataTable();
                using (IDataReader drProgram = sqlDbProgram.ExecuteReader(dbCmdProgram))
                {
                    dtProgram.Load(drProgram);
                }

                return dtProgram;
            }
            catch (Exception ex) { return null; }
        }
        #endregion

        #region dbo.PR_MST_Program_SelectDropDownByCourseID
        public DataTable dbo_PR_MST_Program_SelectDropDownByCourseID(int? CourseID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbProgram = new SqlDatabase(myConnectionString);
                DbCommand dbCmdProgram = sqlDbProgram.GetStoredProcCommand("dbo.PR_MST_Program_SelectDropDownByCourseID");
                sqlDbProgram.AddInParameter(dbCmdProgram, "CourseID", SqlDbType.Int, CourseID);
                sqlDbProgram.AddInParameter(dbCmdProgram, "UserID", SqlDbType.Int, UserID);

                DataTable dtProgram = new DataTable();
                using (IDataReader drProgram = sqlDbProgram.ExecuteReader(dbCmdProgram))
                {
                    dtProgram.Load(drProgram);
                }

                return dtProgram;
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
