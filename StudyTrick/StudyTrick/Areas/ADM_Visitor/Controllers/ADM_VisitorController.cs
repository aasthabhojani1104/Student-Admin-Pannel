using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.ADM_Visitor.Models;
using StudyTrick.Areas.MST_AdmissionYear.Models;
using StudyTrick.Areas.MST_Course.Models;
using StudyTrick.Areas.MST_Program.Models;
using StudyTrick.Areas.MST_Staff.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.ADM_Visitor.Controllers
{
    [Area("ADM_Visitor")]
    [Route("ADM_Visitor/[controller]/[action]")]
    public class ADM_VisitorController : Controller
    {
        #region Add
        public IActionResult Add(int? VisitorID)
        {
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
            if (VisitorID != null)
            {
                ADM_VisitorDAL dalADM_Visitor = new ADM_VisitorDAL();
                ADM_VisitorInterestedCoursesDAL dalADM_VisitorInterestedCourses = new ADM_VisitorInterestedCoursesDAL();

                DataTable dtVisitor = dalADM_Visitor.dbo_PR_ADM_Visitor_SelectByPK(VisitorID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                DataTable dtVisitorInterest = dalADM_VisitorInterestedCourses.dbo_PR_ADM_VisitorInterestedCourses_SelectByVisitorID(Convert.ToInt32(HttpContext.Session.GetString("UserID")), VisitorID);

                ADM_VisitorModel modelADM_Visitor = new ADM_VisitorModel();

                foreach (DataRow drVisitor in dtVisitor.Rows)
                {
                    modelADM_Visitor.VisitorID = Convert.ToInt32(drVisitor["VisitorID"]);
                    modelADM_Visitor.AdmissionYearID = Convert.ToInt32(drVisitor["AdmissionYearID"]);
                    if (drVisitor["CounsellorStaffID"] != DBNull.Value) { modelADM_Visitor.CounsellorStaffID = Convert.ToInt32(drVisitor["CounsellorStaffID"]); }
                    if (drVisitor["VisitorStaffID"] != DBNull.Value) { modelADM_Visitor.VisitorStaffID = Convert.ToInt32(drVisitor["VisitorStaffID"]); }
                    modelADM_Visitor.VisitorName = drVisitor["VisitorName"].ToString();
                    modelADM_Visitor.Phone = drVisitor["Phone"].ToString();
                    modelADM_Visitor.Email = drVisitor["Email"].ToString();
                    if (drVisitor["NoOfPeople"] != DBNull.Value) { modelADM_Visitor.NoOfPeople = Convert.ToInt32(drVisitor["NoOfPeople"]); }
                    if (drVisitor["PassingYear"] != DBNull.Value) { modelADM_Visitor.PassingYear = Convert.ToDateTime(drVisitor["PassingYear"]); }
                    modelADM_Visitor.Address = drVisitor["Address"].ToString();
                    modelADM_Visitor.Description = drVisitor["Description"].ToString();
                }

                //Interested Courses Select
                foreach (DataRow drVisitorInterest in dtVisitorInterest.Rows)
                {
                    modelADM_Visitor.InterestedCoursesID.Add(Convert.ToInt32(drVisitorInterest["CourseID"]));
                }

                TempData["VisitorSaveMSG"] = "Edit";

                return View("ADM_VisitorAddEdit", modelADM_Visitor);
            }
            #endregion

            TempData["VisitorSaveMSG"] = "Add";

            return View("ADM_VisitorAddEdit");
        }
        #endregion

        #region Save
        public IActionResult Save(ADM_VisitorModel modelADM_Visitor)
        {
            ADM_VisitorDAL dalADM_Visitor = new ADM_VisitorDAL();

            if (ModelState.IsValid)
            {
                if (modelADM_Visitor.VisitorID == null)
                    dalADM_Visitor.dbo_PR_ADM_Visitor_Insert(modelADM_Visitor, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                else
                    dalADM_Visitor.dbo_PR_ADM_Visitor_UpdateByPK(modelADM_Visitor, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            }
            return RedirectToAction("Index");
        }
        #endregion

        #region Visitor Select For Modal by Visitor ID
        public IActionResult GetVisitorDetailForModal(int VisitorID)
        {
            ADM_VisitorDAL dalADM_Visitor = new ADM_VisitorDAL();
            DataTable dtVisitor = dalADM_Visitor.dbo_PR_ADM_Visitor_SelectByPK(VisitorID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            ADM_VisitorInterestedCoursesDAL dalADM_VisitorInterestedCourses = new ADM_VisitorInterestedCoursesDAL();
            DataTable dtVisitorInterest = dalADM_VisitorInterestedCourses.dbo_PR_ADM_VisitorInterestedCourses_SelectByVisitorID(Convert.ToInt32(HttpContext.Session.GetString("UserID")), VisitorID);

            List<ADM_VisitorModel> listVisitorDetails = new List<ADM_VisitorModel>();
            ADM_VisitorModel modelADM_Visitor = new ADM_VisitorModel();

            foreach (DataRow drVisitorInterest in dtVisitorInterest.Rows)
            {
                modelADM_Visitor.InterestedCoursesName.Add(drVisitorInterest["CourseName"].ToString());
            }

            foreach (DataRow drVisitor in dtVisitor.Rows)
            {
                modelADM_Visitor.VisitorID = Convert.ToInt32(drVisitor["VisitorID"]);
                modelADM_Visitor.AdmissionYear = drVisitor["AdmissionYear"].ToString();
                modelADM_Visitor.CounsellorStaffName = drVisitor["CounsellorStaffName"].ToString(); 
                modelADM_Visitor.VisitorStaffName = drVisitor["VisitorStaffName"].ToString();
                modelADM_Visitor.VisitorName = drVisitor["VisitorName"].ToString();
                modelADM_Visitor.Phone = drVisitor["Phone"].ToString();
                modelADM_Visitor.Email = drVisitor["Email"].ToString();
                if (drVisitor["NoOfPeople"] != DBNull.Value) { modelADM_Visitor.NoOfPeople = Convert.ToInt32(drVisitor["NoOfPeople"]); }
                if (drVisitor["PassingYear"] != DBNull.Value) { modelADM_Visitor.PassingYear = Convert.ToDateTime(drVisitor["PassingYear"]); }
                modelADM_Visitor.Address = drVisitor["Address"].ToString();
                modelADM_Visitor.Description = drVisitor["Description"].ToString();
                modelADM_Visitor.CreationDate = Convert.ToDateTime(drVisitor["CreationDate"]);
                modelADM_Visitor.ModificationDate = Convert.ToDateTime(drVisitor["ModificationDate"]);

                listVisitorDetails.Add(modelADM_Visitor);
            }

            var vModel = listVisitorDetails;

            return Json(vModel);
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            ADM_VisitorDAL dalADM_Visitor = new ADM_VisitorDAL();
            DataTable dtVisitor = dalADM_Visitor.dbo_PR_ADM_Visitor_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("ADM_VisitorList", dtVisitor);
        }
        #endregion

        #region Delete By PK
        public IActionResult Delete(int VisitorID)
        {
            ADM_VisitorDAL dalADM_Visitor = new ADM_VisitorDAL();
            if (Convert.ToBoolean(dalADM_Visitor.dbo_PR_ADM_Visitor_DeleteByPK(VisitorID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");
            return View("ADM_VisitorList");
        }
        #endregion
    }
}
