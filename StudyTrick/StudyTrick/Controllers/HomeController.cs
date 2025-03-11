using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.ADM_Student.Models;
using StudyTrick.Areas.ADM_Visitor.Models;
using StudyTrick.Areas.LOC_City.Models;
using StudyTrick.Areas.LOC_State.Models;
using StudyTrick.Areas.MST_AdmissionYear.Models;
using StudyTrick.Areas.MST_Course.Models;
using StudyTrick.Areas.MST_Staff.Models;
using StudyTrick.BAL;
using StudyTrick.DAL;
using StudyTrick.Models;
using System.Data;
using System.Diagnostics;

namespace StudyTrick.Controllers
{
    [CheckAccess]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();
            DataTable dtStudent = dalADM_Student.dbo_PR_ADM_Student_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            TempData["TotalAdmissions"] = dtStudent.Rows.Count;

            DataTable dtMaleStudent = dalADM_Student.dbo_PR_ADM_Student_SelectByGender(Convert.ToInt32(HttpContext.Session.GetString("UserID")), "Male");
            TempData["TotalMaleAdmission"] = dtMaleStudent.Rows.Count;

            DataTable dtFemaleStudent = dalADM_Student.dbo_PR_ADM_Student_SelectByGender(Convert.ToInt32(HttpContext.Session.GetString("UserID")), "Female");
            TempData["TotalFemaleAdmission"] = dtFemaleStudent.Rows.Count;

            MST_CourseDAL dalMST_CourseCount = new MST_CourseDAL();
            DataTable dtCourseCount = dalMST_CourseCount.dbo_PR_MST_Course_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            TempData["TotalCourses"] = dtCourseCount.Rows.Count;

            ADM_VisitorDAL dalADM_Visitor = new ADM_VisitorDAL();
            DataTable dtVisitor = dalADM_Visitor.dbo_PR_ADM_Visitor_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            TempData["TotalVisitors"] = dtVisitor.Rows.Count;

            ADM_IntakeDAL dalADM_Intake = new ADM_IntakeDAL();
            DataTable dtIntake = dalADM_Intake.dbo_PR_ADM_Intake_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            TempData["TotalIntakes"] = dtIntake.Rows.Count;

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

            #region Staff Select For Drop Down
            MST_StaffDAL dalMST_Staff = new MST_StaffDAL();
            DataTable dtStaff = dalMST_Staff.dbo_PR_MST_Staff_SelectForDropDown(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<MST_StaffDropDownModel> listStaff = new List<MST_StaffDropDownModel>();

            foreach (DataRow drStaff in dtStaff.Rows)
            {
                MST_StaffDropDownModel modelMST_StaffDropDown = new MST_StaffDropDownModel();
                modelMST_StaffDropDown.StaffID = Convert.ToInt32(drStaff["StaffID"]);
                modelMST_StaffDropDown.StaffName = drStaff["StaffName"].ToString();

                listStaff.Add(modelMST_StaffDropDown);
            }

            ViewBag.StaffList = listStaff;
            #endregion

            #region State Select For Drop Down
            LOC_StateDAL dalLOC_State = new LOC_StateDAL();
            DataTable dtState = dalLOC_State.dbo_PR_LOC_State_SelectForDropDown(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<LOC_StateDropDownModel> listState = new List<LOC_StateDropDownModel>();
            foreach (DataRow drState in dtState.Rows)
            {
                LOC_StateDropDownModel modelLOC_StateDropDown = new LOC_StateDropDownModel();
                modelLOC_StateDropDown.StateID = Convert.ToInt32(drState["StateID"]);
                modelLOC_StateDropDown.StateName = drState["StateName"].ToString();

                listState.Add(modelLOC_StateDropDown);
            }

            ViewBag.StateList = listState;
            #endregion

            #region City Select For Drop Down
            LOC_CityDAL dalLOC_City = new LOC_CityDAL();
            DataTable dtCity = dalLOC_City.dbo_PR_LOC_City_SelectForDropDown(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<LOC_CityDropDownModel> listCity = new List<LOC_CityDropDownModel>();

            foreach (DataRow drCity in dtCity.Rows)
            {
                LOC_CityDropDownModel modelLOC_CityDropDown = new LOC_CityDropDownModel();
                modelLOC_CityDropDown.CityID = Convert.ToInt32(drCity["CityID"]);
                modelLOC_CityDropDown.CityName = drCity["CityName"].ToString();

                listCity.Add(modelLOC_CityDropDown);
            }

            ViewBag.CityList = listCity;
            #endregion

            return View();
        }

        #region Select Admissions By AdmissionYearID
        public IActionResult AdmissionByYear(int AdmissionYearID)
        {
            ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();
            DataTable dtStudent = dalADM_Student.dbo_PR_ADM_Student_SelectByAdmissionYear(Convert.ToInt32(HttpContext.Session.GetString("UserID")), AdmissionYearID);

            TempData["TotalAdmissionByYear"] = dtStudent.Rows.Count;

            List<ADM_StudentDropDownModel> listStudent = new List<ADM_StudentDropDownModel>();

            foreach (DataRow drStudent in dtStudent.Rows)
            {
                ADM_StudentDropDownModel modelADM_StudentDropDown = new ADM_StudentDropDownModel();
                modelADM_StudentDropDown.StudentID = Convert.ToInt32(drStudent["StudentID"]);
                modelADM_StudentDropDown.StudentName = drStudent["VisitorName"].ToString();

                listStudent.Add(modelADM_StudentDropDown);
            }

            return Json(listStudent);
        }
        #endregion

        #region Select Admissions By CourseID
        public IActionResult AdmissionByCourse(int CourseID)
        {
            ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();
            DataTable dtStudent = dalADM_Student.dbo_PR_ADM_Student_SelectByCourseID(Convert.ToInt32(HttpContext.Session.GetString("UserID")), CourseID);

            List<ADM_StudentDropDownModel> listStudent = new List<ADM_StudentDropDownModel>();

            foreach (DataRow drStudent in dtStudent.Rows)
            {
                ADM_StudentDropDownModel modelADM_StudentDropDown = new ADM_StudentDropDownModel();
                modelADM_StudentDropDown.StudentID = Convert.ToInt32(drStudent["StudentID"]);

                listStudent.Add(modelADM_StudentDropDown);
            }

            return Json(listStudent);
        }
        #endregion

        #region Select Admissions By StateID
        public IActionResult AdmissionByStateID(int StateID)
        {
            ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();
            DataTable dtStudent = dalADM_Student.dbo_PR_ADM_Student_SelectByStateID(Convert.ToInt32(HttpContext.Session.GetString("UserID")), StateID);

            List<ADM_StudentDropDownModel> listStudent = new List<ADM_StudentDropDownModel>();

            foreach (DataRow drStudent in dtStudent.Rows)
            {
                ADM_StudentDropDownModel modelADM_StudentDropDown = new ADM_StudentDropDownModel();
                modelADM_StudentDropDown.StudentID = Convert.ToInt32(drStudent["StudentID"]);

                listStudent.Add(modelADM_StudentDropDown);
            }

            return Json(listStudent);
        }
        #endregion

        #region Select Admissions By CityID
        public IActionResult AdmissionByCityID(int CityID)
        {
            ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();
            DataTable dtStudent = dalADM_Student.dbo_PR_ADM_Student_SelectByCityID(Convert.ToInt32(HttpContext.Session.GetString("UserID")), CityID);

            List<ADM_StudentDropDownModel> listStudent = new List<ADM_StudentDropDownModel>();

            foreach (DataRow drStudent in dtStudent.Rows)
            {
                ADM_StudentDropDownModel modelADM_StudentDropDown = new ADM_StudentDropDownModel();
                modelADM_StudentDropDown.StudentID = Convert.ToInt32(drStudent["StudentID"]);

                listStudent.Add(modelADM_StudentDropDown);
            }

            return Json(listStudent);
        }
        #endregion

        #region Select Admissions By StaffID
        public IActionResult AdmissionByStaff(int StaffID)
        {
            ADM_VisitorDAL dalADM_Visitor = new ADM_VisitorDAL();
            DataTable dtVisitor = dalADM_Visitor.dbo_PR_ADM_Visitor_SelectByStaff(Convert.ToInt32(HttpContext.Session.GetString("UserID")), StaffID);

            List<ADM_VisitorDropDownModel> listVisitor = new List<ADM_VisitorDropDownModel>();

            foreach (DataRow drVisitor in dtVisitor.Rows)
            {
                ADM_VisitorDropDownModel modelADM_VisitorDropDown = new ADM_VisitorDropDownModel();
                modelADM_VisitorDropDown.VisitorID = Convert.ToInt32(drVisitor["VisitorID"]);

                listVisitor.Add(modelADM_VisitorDropDown);
            }

            return Json(listVisitor);
        }
        #endregion

        #region Select Admissions By Gender
        public IActionResult AdmissionByGender()
        {
            ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();

            DataTable dtMaleStudent = dalADM_Student.dbo_PR_ADM_Student_SelectByGender(Convert.ToInt32(HttpContext.Session.GetString("UserID")), "Male");
            DataTable dtFemaleStudent = dalADM_Student.dbo_PR_ADM_Student_SelectByGender(Convert.ToInt32(HttpContext.Session.GetString("UserID")), "Female");

            List<int> listGenderAdmission = new List<int>();
            listGenderAdmission.Add(dtMaleStudent.Rows.Count);
            listGenderAdmission.Add(dtFemaleStudent.Rows.Count);

            string[] labelsVal = { "Male", "Female" };

            return Json(new { series = listGenderAdmission, labels = labelsVal });
        }
        #endregion
    }
}