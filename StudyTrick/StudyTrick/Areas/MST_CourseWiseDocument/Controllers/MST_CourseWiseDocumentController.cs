using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.MST_AdmissionYear.Models;
using StudyTrick.Areas.MST_Course.Models;
using StudyTrick.Areas.MST_CourseWiseDocument.Models;
using StudyTrick.Areas.MST_Document.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.MST_CourseWiseDocument.Controllers
{
    [Area("MST_CourseWiseDocument")]
    [Route("MST_CourseWiseDocument/[controller]/[action]")]
    public class MST_CourseWiseDocumentController : Controller
    {
        #region Add
        public IActionResult Add(int? CourseWiseDocumentID)
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

            #region Document Select For Drop Down
            MST_DocumentDAL dalMST_Document = new MST_DocumentDAL();
            DataTable dtDocument = dalMST_Document.dbo_PR_MST_Document_SelectForDropDown(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<MST_DocumentDropDownModel> listDocument = new List<MST_DocumentDropDownModel>();

            foreach (DataRow drDocument in dtDocument.Rows)
            {
                MST_DocumentDropDownModel modelMST_DocumentDropDown = new MST_DocumentDropDownModel();
                modelMST_DocumentDropDown.DocumentID = Convert.ToInt32(drDocument["DocumentID"]);
                modelMST_DocumentDropDown.DocumentName = drDocument["DocumentName"].ToString();

                listDocument.Add(modelMST_DocumentDropDown);
            }

            ViewBag.DocumentList = listDocument;
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

            #region Select By PK
            if (CourseWiseDocumentID != null)
            {
                MST_CourseWiseDocumentDAL dalMST_CourseWiseDocument = new MST_CourseWiseDocumentDAL();
                DataTable dtCourseWiseDocument = dalMST_CourseWiseDocument.dbo_PR_MST_CourseWiseDocument_SelectByPK(CourseWiseDocumentID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                MST_CourseWiseDocumentModel modelMST_CourseWiseDocument = new MST_CourseWiseDocumentModel();

                foreach (DataRow drCourseWiseDocument in dtCourseWiseDocument.Rows)
                {
                    modelMST_CourseWiseDocument.CourseWiseDocumentID = Convert.ToInt32(drCourseWiseDocument["CourseWiseDocumentID"]);
                    modelMST_CourseWiseDocument.CourseID = Convert.ToInt32(drCourseWiseDocument["CourseID"]);
                    modelMST_CourseWiseDocument.DocumentID = Convert.ToInt32(drCourseWiseDocument["DocumentID"]);
                    modelMST_CourseWiseDocument.AdmissionYearID = Convert.ToInt32(drCourseWiseDocument["AdmissionYearID"]);
                    modelMST_CourseWiseDocument.Description = drCourseWiseDocument["Description"].ToString();
                }

                TempData["CourseWiseDocumentSaveMSG"] = "Edit";

                return View("MST_CourseWiseDocumentAddEdit", modelMST_CourseWiseDocument);
            }
            #endregion

            TempData["CourseWiseDocumentSaveMSG"] = "Add";

            return View("MST_CourseWiseDocumentAddEdit");
        }
        #endregion

        #region Save
        public IActionResult Save(MST_CourseWiseDocumentModel modelMST_CourseWiseDocument)
        {
            MST_CourseWiseDocumentDAL dalMST_CourseWiseDocument = new MST_CourseWiseDocumentDAL();
            if (ModelState.IsValid)
            {
                if (modelMST_CourseWiseDocument.CourseWiseDocumentID == null)
                    dalMST_CourseWiseDocument.dbo_PR_MST_CourseWiseDocument_Insert(modelMST_CourseWiseDocument, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                else
                    dalMST_CourseWiseDocument.dbo_PR_MST_CourseWiseDocument_UpdateByPK(modelMST_CourseWiseDocument, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            MST_CourseWiseDocumentDAL dalMST_CourseWiseDocument = new MST_CourseWiseDocumentDAL();
            DataTable dtMST_CourseWiseDocument = dalMST_CourseWiseDocument.dbo_PR_MST_CourseWiseDocument_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("MST_CourseWiseDocumentList", dtMST_CourseWiseDocument);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int CourseWiseDocumentID)
        {
            MST_CourseWiseDocumentDAL dalMST_CourseWiseDocument = new MST_CourseWiseDocumentDAL();
            if (Convert.ToBoolean(dalMST_CourseWiseDocument.dbo_PR_MST_CourseWiseDocument_DeleteByPK(CourseWiseDocumentID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("MST_CourseWiseDocumentList");

        }
        #endregion
    }
}
