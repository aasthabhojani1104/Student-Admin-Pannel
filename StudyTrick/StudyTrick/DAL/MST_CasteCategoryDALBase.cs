using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using StudyTrick.Areas.MST_CasteCategory.Models;
using System.Data;
using System.Data.Common;

namespace StudyTrick.DAL
{
    public class MST_CasteCategoryDALBase : DALHelper
    {
        #region dbo.PR_MST_CasteCategory_SelectAll
        public DataTable dbo_PR_MST_CasteCategory_SelectAll(int UserID)
        {
            try
            {
                SqlDatabase sqlDbCasteCategory = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCasteCategory = sqlDbCasteCategory.GetStoredProcCommand("dbo.PR_MST_CasteCategory_SelectAll");
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

        #region dbo.PR_MST_CasteCategory_SelectByPK
        public DataTable dbo_PR_MST_CasteCategory_SelectByPK(int? CasteCategoryID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCasteCategory = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCasteCategory = sqlDbCasteCategory.GetStoredProcCommand("dbo.PR_MST_CasteCategory_SelectByPK");
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "UserID", SqlDbType.Int, UserID);
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "CasteCategoryID", SqlDbType.Int, CasteCategoryID);

                DataTable dtCasteCategory = new DataTable();
                using (IDataReader drCasteCategory = sqlDbCasteCategory.ExecuteReader(dbCmdCasteCategory))
                {
                    dtCasteCategory.Load(drCasteCategory);
                }

                return dtCasteCategory;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region dbo.PR_MST_CasteCategory_Insert
        public void dbo_PR_MST_CasteCategory_Insert(MST_CasteCategoryModel modelMST_CasteCategory, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCasteCategory = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCasteCategory = sqlDbCasteCategory.GetStoredProcCommand("dbo.PR_MST_CasteCategory_Insert");
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "UserID", SqlDbType.Int, UserID);
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "CategoryName", SqlDbType.NVarChar, modelMST_CasteCategory.CategoryName);
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "Description", SqlDbType.NVarChar, modelMST_CasteCategory.Description);
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "CreationDate", SqlDbType.Date, DBNull.Value);
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "ModificationDate", SqlDbType.Date, DBNull.Value);

                sqlDbCasteCategory.ExecuteNonQuery(dbCmdCasteCategory);
            }
            catch (Exception ex) { }
        }
        #endregion

        #region dbo.PR_MST_CasteCategory_UpdateByPK
        public bool? dbo_PR_MST_CasteCategory_UpdateByPK(MST_CasteCategoryModel modelMST_CasteCategory, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCasteCategory = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCasteCategory = sqlDbCasteCategory.GetStoredProcCommand("dbo.PR_MST_CasteCategory_UpdateByPK");
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "UserID", SqlDbType.Int, UserID);
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "CasteCategoryID", SqlDbType.Int, modelMST_CasteCategory.CasteCategoryID);
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "CategoryName", SqlDbType.NVarChar, modelMST_CasteCategory.CategoryName);
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "Description", SqlDbType.NVarChar, modelMST_CasteCategory.Description);
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "ModificationDate", SqlDbType.Date, DBNull.Value);

                int vReturnValue = sqlDbCasteCategory.ExecuteNonQuery(dbCmdCasteCategory);

                return (vReturnValue == -1 ? false : true);

            }
            catch (Exception e) { return null; }

        }
        #endregion

        #region dbo.PR_MST_Course_DeleteByPK
        public bool? dbo_PR_MST_Course_DeleteByPK(int? CasteCategoryID, int UserID)
        {
            try
            {
                SqlDatabase sqlDbCasteCategory = new SqlDatabase(myConnectionString);
                DbCommand dbCmdCasteCategory = sqlDbCasteCategory.GetStoredProcCommand("dbo.PR_MST_CasteCategory_DeleteByPK");
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "UserID", SqlDbType.Int, UserID);
                sqlDbCasteCategory.AddInParameter(dbCmdCasteCategory, "CasteCategoryID", SqlDbType.Int, CasteCategoryID);

                int vReturnValue = sqlDbCasteCategory.ExecuteNonQuery(dbCmdCasteCategory);

                return (vReturnValue == -1 ? false : true);
            }
            catch (Exception e) { return null; }
        }
        #endregion
    }
}
