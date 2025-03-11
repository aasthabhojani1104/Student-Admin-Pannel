using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.MST_Course.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.MST_Course.Controllers
{
    [Area("MST_Course")]
    [Route("MST_Course/[controller]/[action]")]
    public class MST_CourseController : Controller
    {
        #region Add
        public IActionResult Add(int? CourseID)
        {
            #region Select By PK
            if (CourseID != null)
            {
                MST_CourseDAL dalMST_Course = new MST_CourseDAL();
                DataTable dtCourse = dalMST_Course.dbo_PR_MST_Course_SelectByPK(CourseID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                MST_CourseModel modelMST_Course = new MST_CourseModel();
                foreach (DataRow drCourse in dtCourse.Rows)
                {
                    modelMST_Course.CourseID = Convert.ToInt32(drCourse["CourseID"]);
                    modelMST_Course.CourseName = drCourse["CourseName"].ToString();
                    modelMST_Course.CourseLevel = drCourse["CourseLevel"].ToString();
                    modelMST_Course.CourseDuration = drCourse["CourseDuration"].ToString();
                    modelMST_Course.Description = drCourse["Description"].ToString();
                }
                TempData["CourseSaveMSG"] = "Edit";

                return View("MST_CourseAddEdit", modelMST_Course);
            }
            #endregion

            TempData["CourseSaveMSG"] = "Add";

            return View("MST_CourseAddEdit");
        }
        #endregion

        #region Save
        public IActionResult Save(MST_CourseModel modelMST_Course)
        {
            MST_CourseDAL dalMST_Course = new MST_CourseDAL();
            if (ModelState.IsValid)
            {
                if (modelMST_Course.CourseID == null)
                {
                    dalMST_Course.dbo_PR_MST_Course_Insert(modelMST_Course, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
                else
                {
                    dalMST_Course.dbo_PR_MST_Course_UpdateByPK(modelMST_Course, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            MST_CourseDAL dalMST_Course = new MST_CourseDAL();
            DataTable dtCourse = dalMST_Course.dbo_PR_MST_Course_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("MST_CourseList", dtCourse);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int CourseID)
        {
            MST_CourseDAL dalMST_Course = new MST_CourseDAL();
            if (Convert.ToBoolean(dalMST_Course.dbo_PR_MST_Course_DeleteByPK(CourseID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("MST_CourseList");
        }
        #endregion
    }
}
