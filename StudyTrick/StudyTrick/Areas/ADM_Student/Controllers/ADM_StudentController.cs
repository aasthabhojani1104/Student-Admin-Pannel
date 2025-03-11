using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.ADM_Student.Models;
using StudyTrick.Areas.ADM_Visitor.Models;
using StudyTrick.Areas.LOC_City.Models;
using StudyTrick.Areas.LOC_State.Models;
using StudyTrick.Areas.MST_AdmissionYear.Models;
using StudyTrick.Areas.MST_CasteCategory.Models;
using StudyTrick.Areas.MST_Course.Models;
using StudyTrick.Areas.MST_Program.Models;
using StudyTrick.Areas.MST_Qualification.Models;
using StudyTrick.Areas.MST_Quota.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.ADM_Student.Controllers
{
    [Area("ADM_Student")]
    [Route("ADM_Student/[controller]/[action]")]
    public class ADM_StudentController : Controller
    {
        #region Add
        public IActionResult Add(int? StudentID)
        {
            #region Visitor Select For Drop Down
            ADM_VisitorDAL dalADM_Visitor = new ADM_VisitorDAL();
            DataTable dtVisitor = dalADM_Visitor.dbo_PR_ADM_Visitor_SelectForDropDown(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<ADM_VisitorDropDownModel> listVisitor = new List<ADM_VisitorDropDownModel>();

            foreach (DataRow drVisitor in dtVisitor.Rows)
            {
                ADM_VisitorDropDownModel modelADM_VisitorDropDown = new ADM_VisitorDropDownModel();
                modelADM_VisitorDropDown.VisitorID = Convert.ToInt32(drVisitor["VisitorID"]);
                modelADM_VisitorDropDown.VisitorName = drVisitor["VisitorName"].ToString();

                listVisitor.Add(modelADM_VisitorDropDown);
            }

            ViewBag.VisitorList = listVisitor;
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

            #region Qualification Select For Drop Down
            MST_QualificationDAL dalMST_Qualification = new MST_QualificationDAL();
            DataTable dtQualification = dalMST_Qualification.dbo_PR_MST_Qualification_SelectForDropDown(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<MST_QualificationDropDownModel> listQualification = new List<MST_QualificationDropDownModel>();

            foreach (DataRow drQualification in dtQualification.Rows)
            {
                MST_QualificationDropDownModel modelMST_QualificationDropDown = new MST_QualificationDropDownModel();
                modelMST_QualificationDropDown.QualificationID = Convert.ToInt32(drQualification["QualificationID"]);
                modelMST_QualificationDropDown.QualificationName = drQualification["QualificationName"].ToString();

                listQualification.Add(modelMST_QualificationDropDown);
            }

            ViewBag.QualificationList = listQualification;
            #endregion

            #region Caste Category Select For Drop Down
            MST_CasteCategoryDAL dalMST_CasteCategory = new MST_CasteCategoryDAL();
            DataTable dtCasteCategory = dalMST_CasteCategory.dbo_PR_MST_CasteCategory_SelectForDropDown(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<MST_CasteCategoryDropDownModel> listCasteCategory = new List<MST_CasteCategoryDropDownModel>();

            foreach (DataRow drCasteCategory in dtCasteCategory.Rows)
            {
                MST_CasteCategoryDropDownModel modelMST_CasteCategoryDropDown = new MST_CasteCategoryDropDownModel();
                modelMST_CasteCategoryDropDown.CasteCategoryID = Convert.ToInt32(drCasteCategory["CasteCategoryID"]);
                modelMST_CasteCategoryDropDown.CategoryName = drCasteCategory["CategoryName"].ToString();

                listCasteCategory.Add(modelMST_CasteCategoryDropDown);
            }

            ViewBag.CasteCategoryList = listCasteCategory;
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
            List<LOC_CityDropDownModel> listCity = new List<LOC_CityDropDownModel>();
            ViewBag.CityList = listCity;
            #endregion

            if (StudentID != null)
            {
                ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();
                DataTable dtStudent = dalADM_Student.dbo_PR_ADM_Student_SelectByPK(StudentID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                ADM_StudentModel modelADM_Student = new ADM_StudentModel();

                foreach (DataRow drStudent in dtStudent.Rows)
                {
                    modelADM_Student.StudentID = Convert.ToInt32(drStudent["StudentID"]);
                    modelADM_Student.VisitorID = Convert.ToInt32(drStudent["VisitorID"]);
                    modelADM_Student.StudentName = drStudent["StudentName"].ToString();
                    modelADM_Student.ParentPhone = drStudent["ParentPhone"].ToString();
                    modelADM_Student.Gender = drStudent["Gender"].ToString();
                    if (drStudent["DateOfBirth"] != DBNull.Value) { modelADM_Student.DateOfBirth = Convert.ToDateTime(drStudent["DateOfBirth"]); }
                    modelADM_Student.AdmissionYearID = Convert.ToInt32(drStudent["AdmissionYearID"]);
                    modelADM_Student.QuotaID = Convert.ToInt32(drStudent["QuotaID"]);
                    modelADM_Student.CourseID = Convert.ToInt32(drStudent["CourseID"]);
                    modelADM_Student.ProgramID = Convert.ToInt32(drStudent["ProgramID"]);
                    modelADM_Student.QualificationID = Convert.ToInt32(drStudent["QualificationID"]);
                    modelADM_Student.CasteCategoryID = Convert.ToInt32(drStudent["CasteCategoryID"]);
                    if (drStudent["StateID"] != DBNull.Value) { modelADM_Student.StateID = Convert.ToInt32(drStudent["StateID"]); }
                    if (drStudent["CityID"] != DBNull.Value) { modelADM_Student.CityID = Convert.ToInt32(drStudent["CityID"]); }
                    if (drStudent["SSCPercentage"] != DBNull.Value) { modelADM_Student.SSCPercentage = Convert.ToDecimal(drStudent["SSCPercentage"]); }
                    modelADM_Student.SSCSchoolName = drStudent["SSCSchoolName"].ToString();
                    if (drStudent["SSCPassingYear"] != DBNull.Value) modelADM_Student.SSCPassingYear = Convert.ToInt32(drStudent["SSCPassingYear"]);
                    if (drStudent["HSCPercentage"] != DBNull.Value) { modelADM_Student.HSCPercentage = Convert.ToDecimal(drStudent["HSCPercentage"]); }
                    modelADM_Student.HSCSchoolName = drStudent["HSCSchoolName"].ToString();
                    if (drStudent["HSCPassingYear"] != DBNull.Value) { modelADM_Student.HSCPassingYear = Convert.ToInt32(drStudent["HSCPassingYear"]); }
                    if (drStudent["DiplomaPercentage"] != DBNull.Value) { modelADM_Student.DiplomaPercentage = Convert.ToDecimal(drStudent["DiplomaPercentage"]); }
                    modelADM_Student.DiplomaCollegeName = drStudent["DiplomaCollegeName"].ToString();
                    if (drStudent["DiplomaPassingYear"] != DBNull.Value) { modelADM_Student.DiplomaPassingYear = Convert.ToInt32(drStudent["DiplomaPassingYear"]); }
                    if (drStudent["UGPercentage"] != DBNull.Value) { modelADM_Student.UGPercentage = Convert.ToDecimal(drStudent["UGPercentage"]); }
                    modelADM_Student.UGCollegeName = drStudent["UGCollegeName"].ToString();
                    if (drStudent["UGPassingYear"] != DBNull.Value) { modelADM_Student.UGPassingYear = Convert.ToInt32(drStudent["UGPassingYear"]); }
                    if (drStudent["PGPercentage"] != DBNull.Value) { modelADM_Student.PGPercentage = Convert.ToDecimal(drStudent["PGPercentage"]); }
                    modelADM_Student.PGCollegeName = drStudent["PGCollegeName"].ToString();
                    if (drStudent["PGPassingYear"] != DBNull.Value) { modelADM_Student.PGPassingYear = Convert.ToInt32(drStudent["PGPassingYear"]); }
                    modelADM_Student.PhotoPath = drStudent["PhotoPath"].ToString();
                    modelADM_Student.Description = drStudent["Description"].ToString();
                }
                TempData["StudentSaveMSG"] = "Edit";

                #region Program Select For Drop Down By CourseID
                MST_ProgramDAL dalMST_Program = new MST_ProgramDAL();
                DataTable dtProgram = dalMST_Program.dbo_PR_MST_Program_SelectDropDownByCourseID(modelADM_Student.CourseID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

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

                #region City Select For Drop Down By StateID
                LOC_CityDAL dalLOC_City = new LOC_CityDAL();
                DataTable dtCity = dalLOC_City.dbo_PR_LOC_City_SelectDropDownByStateID(Convert.ToInt32(HttpContext.Session.GetString("UserID")), modelADM_Student.StateID);

                List<LOC_CityDropDownModel> listCityEdit = new List<LOC_CityDropDownModel>();

                foreach (DataRow drCity in dtCity.Rows)
                {
                    LOC_CityDropDownModel modelLOC_CityDropDown = new LOC_CityDropDownModel();
                    modelLOC_CityDropDown.CityID = Convert.ToInt32(drCity["CityID"]);
                    modelLOC_CityDropDown.CityName = drCity["CityName"].ToString();

                    listCityEdit.Add(modelLOC_CityDropDown);
                }

                ViewBag.CityList = listCityEdit;
                #endregion

                return View("ADM_StudentAddEdit", modelADM_Student);
            }

            TempData["StudentSaveMSG"] = "Add";

            return View("ADM_StudentAddEdit");
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

        #region City Select For Drop Down By StateID
        public IActionResult DropDownByState(int? StateID)
        {
            LOC_CityDAL dalLOC_City = new LOC_CityDAL();
            DataTable dtCity = dalLOC_City.dbo_PR_LOC_City_SelectDropDownByStateID(Convert.ToInt32(HttpContext.Session.GetString("UserID")), StateID);

            List<LOC_CityDropDownModel> listCity = new List<LOC_CityDropDownModel>();

            foreach (DataRow drCity in dtCity.Rows)
            {
                LOC_CityDropDownModel modelLOC_CityDropDown = new LOC_CityDropDownModel();
                modelLOC_CityDropDown.CityID = Convert.ToInt32(drCity["CityID"]);
                modelLOC_CityDropDown.CityName = drCity["CityName"].ToString();

                listCity.Add(modelLOC_CityDropDown);
            }

            var vModel = listCity;

            return Json(vModel);
        }
        #endregion

        #region Save
        public IActionResult Save(ADM_StudentModel modelADM_Student)
        {
            if (modelADM_Student.File != null)
            {
                string FilePath = "wwwroot\\Uploads";
                string path = Path.Combine(Directory.GetCurrentDirectory(), FilePath);

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                string fileNameWithPath = Path.Combine(path, modelADM_Student.File.FileName);
                modelADM_Student.PhotoPath = "~" + FilePath.Replace("wwwroot\\", "/") + "/" + modelADM_Student.File.FileName;

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    modelADM_Student.File.CopyTo(stream);
                }
            }

            ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();

            if (ModelState.IsValid)
            {
                if (modelADM_Student.StudentID == null)
                    dalADM_Student.dbo_PR_ADM_Student_Insert(modelADM_Student, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                else
                    dalADM_Student.dbo_PR_ADM_Student_UpdateByPK(modelADM_Student, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Student Select For Modal by Student ID
        public IActionResult GetStudentDetailsForModal(int StudentID)
        {
            ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();
            DataTable dtStudent = dalADM_Student.dbo_PR_ADM_Student_SelectByPK(StudentID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<ADM_StudentModel> listStudentDetails = new List<ADM_StudentModel>();
            ADM_StudentModel modelADM_Student = new ADM_StudentModel();

            foreach (DataRow drStudent in dtStudent.Rows)
            {
                modelADM_Student.StudentID = Convert.ToInt32(drStudent["StudentID"]);
                modelADM_Student.VisitorID = Convert.ToInt32(drStudent["VisitorID"]);
                modelADM_Student.StudentName = drStudent["StudentName"].ToString();
                modelADM_Student.ParentPhone = drStudent["ParentPhone"].ToString();
                modelADM_Student.Gender = drStudent["Gender"].ToString();
                if (drStudent["DateOfBirth"] != DBNull.Value) { modelADM_Student.DateOfBirth = Convert.ToDateTime(drStudent["DateOfBirth"]); }
                modelADM_Student.AdmissionYearID = Convert.ToInt32(drStudent["AdmissionYearID"]);
                modelADM_Student.QuotaID = Convert.ToInt32(drStudent["QuotaID"]);
                modelADM_Student.CourseID = Convert.ToInt32(drStudent["CourseID"]);
                modelADM_Student.ProgramID = Convert.ToInt32(drStudent["ProgramID"]);
                modelADM_Student.QualificationID = Convert.ToInt32(drStudent["QualificationID"]);
                modelADM_Student.CasteCategoryID = Convert.ToInt32(drStudent["CasteCategoryID"]);
                if (drStudent["StateID"] != DBNull.Value) { modelADM_Student.StateID = Convert.ToInt32(drStudent["StateID"]); }
                if (drStudent["CityID"] != DBNull.Value) { modelADM_Student.CityID = Convert.ToInt32(drStudent["CityID"]); }
                if (drStudent["SSCPercentage"] != DBNull.Value) { modelADM_Student.SSCPercentage = Convert.ToDecimal(drStudent["SSCPercentage"]); }
                modelADM_Student.SSCSchoolName = drStudent["SSCSchoolName"].ToString();
                if (drStudent["SSCPassingYear"] != DBNull.Value) modelADM_Student.SSCPassingYear = Convert.ToInt32(drStudent["SSCPassingYear"]);
                if (drStudent["HSCPercentage"] != DBNull.Value) { modelADM_Student.HSCPercentage = Convert.ToDecimal(drStudent["HSCPercentage"]); }
                modelADM_Student.HSCSchoolName = drStudent["HSCSchoolName"].ToString();
                if (drStudent["HSCPassingYear"] != DBNull.Value) { modelADM_Student.HSCPassingYear = Convert.ToInt32(drStudent["HSCPassingYear"]); }
                if (drStudent["DiplomaPercentage"] != DBNull.Value) { modelADM_Student.DiplomaPercentage = Convert.ToDecimal(drStudent["DiplomaPercentage"]); }
                modelADM_Student.DiplomaCollegeName = drStudent["DiplomaCollegeName"].ToString();
                if (drStudent["DiplomaPassingYear"] != DBNull.Value) { modelADM_Student.DiplomaPassingYear = Convert.ToInt32(drStudent["DiplomaPassingYear"]); }
                if (drStudent["UGPercentage"] != DBNull.Value) { modelADM_Student.UGPercentage = Convert.ToDecimal(drStudent["UGPercentage"]); }
                modelADM_Student.UGCollegeName = drStudent["UGCollegeName"].ToString();
                if (drStudent["UGPassingYear"] != DBNull.Value) { modelADM_Student.UGPassingYear = Convert.ToInt32(drStudent["UGPassingYear"]); }
                if (drStudent["PGPercentage"] != DBNull.Value) { modelADM_Student.PGPercentage = Convert.ToDecimal(drStudent["PGPercentage"]); }
                modelADM_Student.PGCollegeName = drStudent["PGCollegeName"].ToString();
                if (drStudent["PGPassingYear"] != DBNull.Value) { modelADM_Student.PGPassingYear = Convert.ToInt32(drStudent["PGPassingYear"]); }
                modelADM_Student.PhotoPath = drStudent["PhotoPath"].ToString();
                modelADM_Student.Description = drStudent["Description"].ToString();
                modelADM_Student.CreationDate = Convert.ToDateTime(drStudent["CreationDate"]);
                modelADM_Student.ModificationDate = Convert.ToDateTime(drStudent["ModificationDate"]);

                listStudentDetails.Add(modelADM_Student);
            }

            var vModel = listStudentDetails;

            return Json(vModel);
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();
            DataTable dtStudent = dalADM_Student.dbo_PR_ADM_Student_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("ADM_StudentList", dtStudent);
        }
        #endregion

        #region Delete By PK
        public IActionResult Delete(int StudentID)
        {
            ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();
            if (Convert.ToBoolean(dalADM_Student.dbo_PR_ADM_Student_DeleteByPK(StudentID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("ADM_StudentList");
        }
        #endregion
    }
}
