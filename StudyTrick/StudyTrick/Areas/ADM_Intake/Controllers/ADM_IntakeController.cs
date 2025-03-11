using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.ADM_Intake.Models;
using StudyTrick.Areas.MST_AdmissionYear.Models;
using StudyTrick.Areas.MST_Course.Models;
using StudyTrick.Areas.MST_Program.Models;
using StudyTrick.Areas.MST_Quota.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.ADM_Intake.Controllers
{
    [Area("ADM_Intake")]
    [Route("ADM_Intake/[controller]/[action]")]
    public class ADM_IntakeController : Controller
    {
        #region Add
        public IActionResult Add(int? IntakeID)
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

            #region Program Select For Drop Down
            List<MST_ProgramDropDownModel> listProgram = new List<MST_ProgramDropDownModel>();
            ViewBag.ProgramList = listProgram;
            #endregion

            #region Admission Year Select For Drop Down
            MST_AdmissionYearDAL dalMST_AdmissionYear = new MST_AdmissionYearDAL();
            DataTable dtAdmissionYear = dalMST_AdmissionYear.dbo_PR_MST_AdmissionYear_SelectForDropDown(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<MST_AdmissionYearDropDownModel> listAdmissionYear = new List<MST_AdmissionYearDropDownModel>();
            foreach (DataRow drAdmissionYear in dtAdmissionYear.Rows)
            {
                MST_AdmissionYearDropDownModel modelMST_AdmissionYearDropDown = new MST_AdmissionYearDropDownModel();
                modelMST_AdmissionYearDropDown.AdmissionYearID = Convert.ToInt32(drAdmissionYear["AdmissionYearID"]);
                modelMST_AdmissionYearDropDown.AdmissionYear = Convert.ToInt32(drAdmissionYear["AdmissionYear"]);

                listAdmissionYear.Add(modelMST_AdmissionYearDropDown);
            }

            ViewBag.AdmissionYearList = listAdmissionYear;
            #endregion

            #region Quota Select For Drop Down
            MST_QuotaDAL dalMST_Quota = new MST_QuotaDAL();
            DataTable dtQuota = dalMST_Quota.dbo_PR_MST_Quota_SelectForDropDown(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<MST_QuotaDropDownModel> listQuota = new List<MST_QuotaDropDownModel>();

            foreach (DataRow drQuota in dtQuota.Rows)
            {
                MST_QuotaDropDownModel modelMST_QuotaDropDown = new MST_QuotaDropDownModel();
                modelMST_QuotaDropDown.QuotaID = Convert.ToInt32(drQuota["QuotaID"]);
                modelMST_QuotaDropDown.QuotaName = drQuota["QuotaName"].ToString();

                listQuota.Add(modelMST_QuotaDropDown);
            }

            ViewBag.QuotaList = listQuota;
            #endregion

            #region Select By PK
            if (IntakeID != null)
            {
                ADM_IntakeDAL dalADM_Intake = new ADM_IntakeDAL();
                DataTable dtIntake = dalADM_Intake.dbo_PR_ADM_Intake_SelectByPK(IntakeID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                ADM_IntakeModel modelADM_Intake = new ADM_IntakeModel();

                foreach (DataRow drIntake in dtIntake.Rows)
                {
                    modelADM_Intake.CourseID = Convert.ToInt32(drIntake["CourseID"]);
                    modelADM_Intake.ProgramID = Convert.ToInt32(drIntake["ProgramID"]);
                    modelADM_Intake.AdmissionYearID = Convert.ToInt32(drIntake["AdmissionYearID"]);
                    modelADM_Intake.QuotaID = Convert.ToInt32(drIntake["QuotaID"]);
                    modelADM_Intake.Intake = Convert.ToInt32(drIntake["Intake"]);
                    modelADM_Intake.Description = drIntake["Description"].ToString();
                }

                #region Program Select For Drop Down By CourseID
                MST_ProgramDAL dalMST_Program = new MST_ProgramDAL();
                DataTable dtProgram = dalMST_Program.dbo_PR_MST_Program_SelectDropDownByCourseID(modelADM_Intake.CourseID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                List<MST_ProgramDropDownModel> listProgramEdit = new List<MST_ProgramDropDownModel>();

                foreach (DataRow drProgram in dtProgram.Rows)
                {
                    MST_ProgramDropDownModel modelMST_ProgramDropDown = new MST_ProgramDropDownModel();
                    modelMST_ProgramDropDown.ProgramID = Convert.ToInt32(drProgram["ProgramID"]);
                    modelMST_ProgramDropDown.ProgramName = drProgram["ProgramName"].ToString();

                    listProgramEdit.Add(modelMST_ProgramDropDown);
                }

                ViewBag.ProgramList = listProgramEdit;
                #endregion

                return View("ADM_IntakeAddEdit", modelADM_Intake);
            }
            #endregion

            TempData["IntakeSaveMSG"] = "Add";

            return View("ADM_IntakeAddEdit");
        }
        #endregion

        #region Program Select For Drop Down By CourseID
        public IActionResult DropDownByCourse(int? CourseID)
        {
            MST_ProgramDAL dalMST_Program = new MST_ProgramDAL();
            DataTable dtProgram = dalMST_Program.dbo_PR_MST_Program_SelectDropDownByCourseID(CourseID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<MST_ProgramDropDownModel> listProgram = new List<MST_ProgramDropDownModel>();

            foreach (DataRow drProgram in dtProgram.Rows)
            {
                MST_ProgramDropDownModel modelMST_ProgramDropDown = new MST_ProgramDropDownModel();
                modelMST_ProgramDropDown.ProgramID = Convert.ToInt32(drProgram["ProgramID"]);
                modelMST_ProgramDropDown.ProgramName = drProgram["ProgramName"].ToString();

                listProgram.Add(modelMST_ProgramDropDown);
            }

            var vModel = listProgram;

            return Json(vModel);
        }
        #endregion

        #region Save
        public IActionResult Save(ADM_IntakeModel modelADM_Intake)
        {
            ADM_IntakeDAL dalADM_Intake = new ADM_IntakeDAL();

            if (ModelState.IsValid)
            {
                if (modelADM_Intake.IntakeID == null)
                    dalADM_Intake.dbo_PR_ADM_Intake_Insert(modelADM_Intake, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                else
                    dalADM_Intake.dbo_PR_ADM_Intake_UpdateByPK(modelADM_Intake, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            ADM_IntakeDAL dalADM_Intake = new ADM_IntakeDAL();
            DataTable dtIntake = dalADM_Intake.dbo_PR_ADM_Intake_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("ADM_IntakeList", dtIntake);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int IntakeID)
        {
            ADM_IntakeDAL dalADM_Intake = new ADM_IntakeDAL();
            if (Convert.ToBoolean(dalADM_Intake.dbo_PR_ADM_Intake_DeleteByPK(IntakeID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("ADM_IntakeList");
        }
        #endregion
    }
}
