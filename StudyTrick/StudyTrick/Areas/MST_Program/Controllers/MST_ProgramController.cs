using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.MST_Course.Models;
using StudyTrick.Areas.MST_Program.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.MST_Program.Controllers
{
    [Area("MST_Program")]
    [Route("MST_Program/[controller]/[action]")]
    public class MST_ProgramController : Controller
    {
        #region Add
        public IActionResult Add(int? ProgramID)
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
            if (ProgramID != null)
            {
                MST_ProgramDAL dalMST_Program = new MST_ProgramDAL();
                DataTable dtProgram = dalMST_Program.dbo_PR_MST_Program_SelectByPK(ProgramID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                MST_ProgramModel modelMST_Program = new MST_ProgramModel();

                foreach (DataRow drProgram in dtProgram.Rows)
                {
                    modelMST_Program.ProgramID = Convert.ToInt32(drProgram["ProgramID"]);
                    modelMST_Program.CourseID = Convert.ToInt32(drProgram["CourseID"]);
                    modelMST_Program.ProgramName = drProgram["ProgramName"].ToString();
                    modelMST_Program.Description = drProgram["Description"].ToString();
                }

                TempData["ProgramSaveMSG"] = "Edit";

                return View("MST_ProgramAddEdit", modelMST_Program);
            }
            #endregion

            TempData["ProgramSaveMSG"] = "Add";

            return View("MST_ProgramAddEdit");
        }
        #endregion

        #region Save
        public IActionResult Save(MST_ProgramModel modelMST_Program)
        {
            MST_ProgramDAL dalMST_Program = new MST_ProgramDAL();

            if (ModelState.IsValid)
            {
                if (modelMST_Program.ProgramID == null)
                    dalMST_Program.dbo_PR_MST_Program_Insert(modelMST_Program, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                else
                    dalMST_Program.dbo_PR_MST_Program_UpdateByPK(modelMST_Program, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            MST_ProgramDAL dalMST_Program = new MST_ProgramDAL();
            DataTable dtProgram = dalMST_Program.dbo_PR_MST_Program_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("MST_ProgramList", dtProgram);
        }
        #endregion

        #region Delete By PK
        public IActionResult Delete(int ProgramID)
        {
            MST_ProgramDAL dalMST_Program = new MST_ProgramDAL();
            if (Convert.ToBoolean(dalMST_Program.dbo_PR_MST_Program_DeleteByPK(ProgramID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("MST_ProgramList");
        }
        #endregion
    }
}
