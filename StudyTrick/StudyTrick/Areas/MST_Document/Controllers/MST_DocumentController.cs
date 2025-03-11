using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.MST_Document.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.MST_Document.Controllers
{
    [Area("MST_Document")]
    [Route("MST_Document/[controller]/[action]")]
    public class MST_DocumentController : Controller
    {
        #region Add
        public IActionResult Add(int? DocumentID)
        {
            #region Select By PK
            if (DocumentID != null)
            {
                MST_DocumentDAL dalMST_Document = new MST_DocumentDAL();
                DataTable dtDocument = dalMST_Document.dbo_PR_MST_Document_SelectByPK(DocumentID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                MST_DocumentModel modelMST_Document = new MST_DocumentModel();
                foreach (DataRow drDocument in dtDocument.Rows)
                {
                    modelMST_Document.DocumentID = Convert.ToInt32(drDocument["DocumentID"]);
                    modelMST_Document.DocumentName = drDocument["DocumentName"].ToString();
                    modelMST_Document.Description = drDocument["Description"].ToString();
                }
                TempData["DocumentSaveMSG"] = "Edit";

                return View("MST_DocumentAddEdit", modelMST_Document);
            }
            #endregion

            TempData["DocumentSaveMSG"] = "Add";

            return View("MST_DocumentAddEdit");
        }
        #endregion

        #region Save
        public IActionResult Save(MST_DocumentModel modelMST_Document)
        {
            MST_DocumentDAL dalMST_Document = new MST_DocumentDAL();
            if (ModelState.IsValid)
            {
                if (modelMST_Document.DocumentID == null)
                {
                    dalMST_Document.dbo_PR_MST_Document_Insert(modelMST_Document, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
                else
                {
                    dalMST_Document.dbo_PR_MST_Document_UpdateByPK(modelMST_Document, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            MST_DocumentDAL dalMST_Document = new MST_DocumentDAL();
            DataTable dtDocument = dalMST_Document.dbo_PR_MST_Document_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("MST_DocumentList", dtDocument);
        }
        #endregion

        #region Delete By PK
        public IActionResult Delete(int DocumentID)
        {
            MST_DocumentDAL dalMST_Document = new MST_DocumentDAL();
            if (Convert.ToBoolean(dalMST_Document.dbo_PR_MST_Document_DeleteByPK(DocumentID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("MST_DocumentList");
        }
        #endregion
    }
}
