using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_CasteCategoryDAL : MST_CasteCategoryDALBase
    {
        #region dbo.PR_MST_CasteCategory_SelectForDropDown
        public DataTable dbo_PR_MST_CasteCategory_SelectForDropDown(int UserID)
        {
            try
            {
                SqlDatabase sqlDbCasteCategory = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCasteCategory = sqlDbCasteCategory.GetStoredProcCommand("dbo.PR_MST_CasteCategory_SelectForDropDown");
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "UserID", SqlDbType.Int, UserID);

                DataTable dtCasteCategory = new DataTable();
                using (IDataReader drCasteCategory = sqlDbCasteCategory.ExecuteReader(dbCmdCasteCategory))
                {
                    dtCasteCategory.Load(drCasteCategory);
                }

                return dtCasteCategory;
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
