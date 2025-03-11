using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.MST_Course.Models;
using StudyTrick.Areas.MST_Quota.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.MST_Quota.Controllers
{
    [Area("MST_Quota")]
    [Route("MST_Quota/[controller]/[action]")]
    public class MST_QuotaController : Controller
    {
        #region Add
        public IActionResult Add(int? QuotaID)
        {
            #region Course Select For Drop Down
            MST_CourseDAL dalMST_Course = new MST_CourseDAL();
            DataTable dtCourse = dalMST_Course.dbo_PR_MST_Course_SelectForDropDown(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<MST_CourseDropDownModel> listCourse = new List<MST_CourseDropDownModel>();

            foreach (DataRow drCourse in dtCourse.Rows)
            {
                MST_CourseDropDownModel modelMST_CourseDropDown = new MST_CourseDropDownModel();
                modelMST_CourseDropDown.CourseID = Convert.ToInt32(drCourse["CourseID"]);
                modelMST_CourseDropDown.CourseName = drCourse["CourseName"].ToString();

                listCourse.Add(modelMST_CourseDropDown);
            }

            ViewBag.CourseList = listCourse;
            #endregion

            #region Select By PK
            if (QuotaID != null)
            {
                MST_QuotaDAL dalMST_Quota = new MST_QuotaDAL();
                DataTable dtQuota = dalMST_Quota.dbo_PR_MST_Quota_SelectByPK(QuotaID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                MST_QuotaModel modelMST_Quota = new MST_QuotaModel();
                foreach (DataRow drQuota in dtQuota.Rows)
                {
                    modelMST_Quota.QuotaID = Convert.ToInt32(drQuota["QuotaID"]);
                    modelMST_Quota.CourseID = Convert.ToInt32(drQuota["CourseID"]);
                    modelMST_Quota.QuotaName = drQuota["QuotaName"].ToString();
                    modelMST_Quota.Description = drQuota["Description"].ToString();
                }
                TempData["QuotaSaveMSG"] = "Edit";

                return View("MST_QuotaAddEdit", modelMST_Quota);
            }
            #endregion

            TempData["QuotaSaveMSG"] = "Add";

            return View("MST_QuotaAddEdit");
        }
        #endregion

        #region Save
        public IActionResult Save(MST_QuotaModel modelMST_Quota)
        {
            MST_QuotaDAL dalMST_Quota = new MST_QuotaDAL();

            if (ModelState.IsValid)
            {
                if (modelMST_Quota.QuotaID == null)
                    dalMST_Quota.dbo_PR_MST_Quota_Insert(modelMST_Quota, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                else
                    dalMST_Quota.dbo_PR_MST_Quota_UpdateByPK(modelMST_Quota, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            MST_QuotaDAL dalMST_Quota = new MST_QuotaDAL();
            DataTable dtQuota = dalMST_Quota.dbo_PR_MST_Quota_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("MST_QuotaList", dtQuota);
        }
        #endregion

        #region Delete By PK
        public IActionResult Delete(int QuotaID)
        {
            MST_QuotaDAL dalMST_Quota = new MST_QuotaDAL();

            if (Convert.ToBoolean(dalMST_Quota.dbo_PR_MST_Quota_DeleteByPK(QuotaID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("MST_QuotaList");
        }
        #endregion
    }
}
