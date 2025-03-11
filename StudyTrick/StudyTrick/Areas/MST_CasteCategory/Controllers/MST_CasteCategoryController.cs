using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.MST_CasteCategory.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.MST_CasteCategory.Controllers
{
    [Area("MST_CasteCategory")]
    [Route("MST_CasteCategory/[controller]/[action]")]
    public class MST_CasteCategoryController : Controller
    {
        #region Add
        public IActionResult Add(int? CasteCategoryID)
        {
            #region Select By PK
            if (CasteCategoryID != null)
            {
                MST_CasteCategoryDAL dalMST_CasteCategory = new MST_CasteCategoryDAL();
                DataTable dtCasteCategory = dalMST_CasteCategory.dbo_PR_MST_CasteCategory_SelectByPK(CasteCategoryID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                MST_CasteCategoryModel modelMST_CasteCategory = new MST_CasteCategoryModel();
                foreach (DataRow drCasteCategory in dtCasteCategory.Rows)
                {
                    modelMST_CasteCategory.CasteCategoryID = Convert.ToInt32(drCasteCategory["CasteCategoryID"]);
                    modelMST_CasteCategory.CategoryName = drCasteCategory["CategoryName"].ToString();
                    modelMST_CasteCategory.Description = drCasteCategory["Description"].ToString();
                }
                TempData["CasteCategorySaveMSG"] = "Edit";

                return View("MST_CasteCategoryAddEdit", modelMST_CasteCategory);
            }
            TempData["CasteCategorySaveMSG"] = "Add";

            #endregion
            return View("MST_CasteCategoryAddEdit");
        }
        #endregion

        #region Save
        public IActionResult Save(MST_CasteCategoryModel modelMST_CasteCategory)
        {
            MST_CasteCategoryDAL dalMST_CasteCategory = new MST_CasteCategoryDAL();
            if (ModelState.IsValid)
            {
                if (modelMST_CasteCategory.CasteCategoryID == null)
                {
                    dalMST_CasteCategory.dbo_PR_MST_CasteCategory_Insert(modelMST_CasteCategory, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
                else
                {
                    dalMST_CasteCategory.dbo_PR_MST_CasteCategory_UpdateByPK(modelMST_CasteCategory, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            MST_CasteCategoryDAL dalMST_CasteCategory = new MST_CasteCategoryDAL();
            DataTable dtCasteCategory = dalMST_CasteCategory.dbo_PR_MST_CasteCategory_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("MST_CasteCategoryList", dtCasteCategory);
        }
        #endregion

        #region Delete By PK
        public IActionResult Delete(int CasteCategoryID)
        {
            MST_CasteCategoryDAL dalMST_CasteCategory = new MST_CasteCategoryDAL();
            if (Convert.ToBoolean(dalMST_CasteCategory.dbo_PR_MST_Course_DeleteByPK(CasteCategoryID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("MST_CasteCategoryList");
        }
        #endregion
    }
}
