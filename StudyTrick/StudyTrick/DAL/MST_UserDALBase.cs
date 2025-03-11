using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.MST_User.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    #region dbo.PR_MST_User_SelectByUserNamePassword
    public class MST_UserDALBase : DALHelper
    {
        public DataTable dbo_PR_MST_User_SelectByUserNamePassword(MST_UserModel modelMST_User)
        {
            try
            {
                SqlDatabase sqlDbUser = new SqlDatabase(myConnectionString);
                DbCommand dbCmdUser = sqlDbUser.GetStoredProcCommand("dbo.PR_MST_User_SelectByUserNamePassword");
                sqlDbUser.AddInParameter(dbCmdUser, "UserName", SqlDbType.NVarChar, modelMST_User.UserName);
                sqlDbUser.AddInParameter(dbCmdUser, "Password", SqlDbType.NVarChar, modelMST_User.Password);

                DataTable dtUser = new DataTable();
                using (IDataReader drUser = sqlDbUser.ExecuteReader(dbCmdUser))
                {
                    dtUser.Load(drUser);
                }

                return dtUser;
            }
            catch (Exception ex) { return null; }
        }
    }
    #endregion
}
