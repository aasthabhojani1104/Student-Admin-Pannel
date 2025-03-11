using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.ADM_Student.Models;
using StudyTrick.Areas.ADM_StudentDocument.Models;
using StudyTrick.Areas.MST_Document.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.ADM_StudentDocument.Controllers
{
    [Area("ADM_StudentDocument")]
    [Route("ADM_StudentDocument/[controller]/[action]")]
    public class ADM_StudentDocumentController : Controller
    {
        #region Add
        public IActionResult Add(int? StudentDocumentID)
        {
            #region Student Select For Drop Down
            ADM_StudentDAL dalADM_Student = new ADM_StudentDAL();
            DataTable dtStudent = dalADM_Student.dbo_PR_ADM_Student_SelectForDropDown(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            List<ADM_StudentDropDownModel> listStudent = new List<ADM_StudentDropDownModel>();

            foreach (DataRow drStudent in dtStudent.Rows)
            {
                ADM_StudentDropDownModel modelADM_StudentDropDown = new ADM_StudentDropDownModel();
                modelADM_StudentDropDown.StudentID = Convert.ToInt32(drStudent["StudentID"]);
                modelADM_StudentDropDown.StudentName = drStudent["StudentName"].ToString();

                listStudent.Add(modelADM_StudentDropDown);
            }

            ViewBag.StudentList = listStudent;
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

            if (StudentDocumentID != null)
            {
                ADM_StudentDocumentDAL dalADM_StudentDocument = new ADM_StudentDocumentDAL();
                DataTable dtStudentDocument = dalADM_StudentDocument.dbo_PR_ADM_StudentDocument_SelectByPK(StudentDocumentID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                ADM_StudentDocumentModel modelADM_StudentDocument = new ADM_StudentDocumentModel();

                foreach (DataRow drStudentDocument in dtStudentDocument.Rows)
                {
                    modelADM_StudentDocument.StudentDocumentID = Convert.ToInt32(drStudentDocument["StudentDocumentID"]);
                    modelADM_StudentDocument.StudentID = Convert.ToInt32(drStudentDocument["StudentID"]);
                    modelADM_StudentDocument.DocumentID = Convert.ToInt32(drStudentDocument["DocumentID"]);
                    modelADM_StudentDocument.DocumentPath = drStudentDocument["DocumentPath"].ToString();
                    modelADM_StudentDocument.Description = drStudentDocument["Description"].ToString();
                }

                TempData["StudentDocumentSaveMSG"] = "Edit";

                return View("ADM_StudentDocumentAddEdit", modelADM_StudentDocument);
            }

            TempData["StudentDocumentSaveMSG"] = "Add";

            return View("ADM_StudentDocumentAddEdit");
        }
        #endregion

        #region Save
        public IActionResult Save(ADM_StudentDocumentModel modelADM_StudentDocument)
        {
            if (modelADM_StudentDocument.File != null)
            {
                string FilePath = "wwwroot\\Uploads";
                string path = Path.Combine(Directory.GetCurrentDirectory(), FilePath);

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                string fileNameWithPath = Path.Combine(path, modelADM_StudentDocument.File.FileName);
                modelADM_StudentDocument.DocumentPath = "~" + FilePath.Replace("wwwroot\\", "/") + "/" + modelADM_StudentDocument.File.FileName;

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    modelADM_StudentDocument.File.CopyTo(stream);
                }
            }

            ADM_StudentDocumentDAL dalADM_StudentDocument = new ADM_StudentDocumentDAL();

            if (ModelState.IsValid)
            {
                if (modelADM_StudentDocument.StudentDocumentID == null)
                    dalADM_StudentDocument.dbo_PR_ADM_StudentDocument_Insert(modelADM_StudentDocument, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                else
                    dalADM_StudentDocument.dbo_PR_ADM_StudentDocument_UpdateByPK(modelADM_StudentDocument, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            ADM_StudentDocumentDAL dalADM_StudentDocument = new ADM_StudentDocumentDAL();
            DataTable dtStudentDocument = dalADM_StudentDocument.dbo_PR_ADM_StudentDocument_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("ADM_StudentDocumentList", dtStudentDocument);
        }
        #endregion

        #region Delete By PK
        public IActionResult Delete(int StudentDocumentID)
        {
            ADM_StudentDocumentDAL dalADM_StudentDocument = new ADM_StudentDocumentDAL();
            if (Convert.ToBoolean(dalADM_StudentDocument.dbo_PR_ADM_StudentDocument_DeleteByPK(StudentDocumentID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("ADM_StudentDocumentList");
        }
        #endregion
    }
}
