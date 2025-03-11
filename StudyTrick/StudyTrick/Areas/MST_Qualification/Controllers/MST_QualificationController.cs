using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.MST_Qualification.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.MST_Qualification.Controllers
{
    [Area("MST_Qualification")]
    [Route("MST_Qualification/[controller]/[action]")]
    public class MST_QualificationController : Controller
    {
        #region Add
        public IActionResult Add(int? QualificationID)
        {
            #region Select By PK
            if (QualificationID != null)
            {
                MST_QualificationDAL dalMST_Qualification = new MST_QualificationDAL();
                DataTable dtQualification = dalMST_Qualification.dbo_PR_MST_Qualification_SelectByPK(QualificationID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                MST_QualificationModel modelMST_Qualification = new MST_QualificationModel();
                foreach (DataRow drQualification in dtQualification.Rows)
                {
                    modelMST_Qualification.QualificationID = Convert.ToInt32(drQualification["QualificationID"]);
                    modelMST_Qualification.QualificationName = drQualification["QualificationName"].ToString();
                    modelMST_Qualification.Description = drQualification["Description"].ToString();
                }
                TempData["QualificationSaveMSG"] = "Edit";

                return View("MST_QualificationAddEdit", modelMST_Qualification);
            }
            #endregion

            TempData["QualificationSaveMSG"] = "Add";

            return View("MST_QualificationAddEdit");
        }
        #endregion

        #region Save
        public IActionResult Save(MST_QualificationModel modelMST_Qualification)
        {
            MST_QualificationDAL dalMST_Qualification = new MST_QualificationDAL();
            if (ModelState.IsValid)
            {
                if (modelMST_Qualification.QualificationID == null)
                    dalMST_Qualification.dbo_PR_MST_Qualification_Insert(modelMST_Qualification, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                else
                    dalMST_Qualification.dbo_PR_MST_Qualification_UpdateByPK(modelMST_Qualification, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            MST_QualificationDAL dalMST_Qualification = new MST_QualificationDAL();
            DataTable dtQualification = dalMST_Qualification.dbo_PR_MST_Qualification_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("MST_QualificationList", dtQualification);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int QualificationID)
        {
            MST_QualificationDAL dalMST_Qualification = new MST_QualificationDAL();
            if (Convert.ToBoolean(dalMST_Qualification.dbo_PR_MST_Qualification_DeleteByPK(QualificationID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("MST_QualificationList");
        }
        #endregion
    }
}
