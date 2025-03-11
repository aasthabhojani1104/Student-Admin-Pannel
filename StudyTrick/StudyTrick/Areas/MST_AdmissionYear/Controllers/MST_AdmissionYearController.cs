using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.MST_AdmissionYear.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.MST_AdmissionYear.Controllers
{
    [Area("MST_AdmissionYear")]
    [Route("MST_AdmissionYear/[controller]/[action]")]
    public class MST_AdmissionYearController : Controller
    {
        #region Add
        public IActionResult Add(int? AdmissionYearID)
        {
            if (AdmissionYearID != null)
            {
                MST_AdmissionYearDAL dalAdmissionYearDAL = new MST_AdmissionYearDAL();
                DataTable dtAdmissionYear = dalAdmissionYearDAL.dbo_PR_MST_AdmissionYear_SelectByPK(AdmissionYearID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                MST_AdmissionYearModel modelMST_AdmissionYear = new MST_AdmissionYearModel();

                foreach (DataRow drAdmissionYear in dtAdmissionYear.Rows)
                {
                    modelMST_AdmissionYear.AdmissionYearID = Convert.ToInt32(drAdmissionYear["AdmissionYearID"]);
                    modelMST_AdmissionYear.AdmissionYear = Convert.ToInt32(drAdmissionYear["AdmissionYear"]);
                    modelMST_AdmissionYear.Description = drAdmissionYear["Description"].ToString();
                }
                TempData["AdmissionYearSaveMSG"] = "Edit";

                return View("MST_AdmissionYearAddEdit", modelMST_AdmissionYear);
            }
            TempData["AdmissionYearSaveMSG"] = "Add";

            return View("MST_AdmissionYearAddEdit");
        }
        #endregion

        #region Save
        [HttpPost]
        public IActionResult Save(MST_AdmissionYearModel modelAdmissionYearModel)
        {
            MST_AdmissionYearDAL dalMST_AdmissionYear = new MST_AdmissionYearDAL();

            if (ModelState.IsValid)
            {
                if (modelAdmissionYearModel.AdmissionYearID == null)
                {
                    dalMST_AdmissionYear.dbo_PR_MST_AdmissionYear_Insert(modelAdmissionYearModel, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
                else
                {
                    dalMST_AdmissionYear.dbo_PR_MST_AdmissionYear_UpdateByPK(modelAdmissionYearModel, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            MST_AdmissionYearDAL dalMST_AdmissionYear = new MST_AdmissionYearDAL();

            DataTable dtAdmissionYear = dalMST_AdmissionYear.dbo_PR_MST_AdmissionYear_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("MST_AdmissionYearList", dtAdmissionYear);
        }
        #endregion

        #region Delete By PK
        public IActionResult Delete(int AdmissionYearID)
        {
            MST_AdmissionYearDAL dalAdmissionYear = new MST_AdmissionYearDAL();

            bool isDeleted = Convert.ToBoolean(
                dalAdmissionYear.dbo_PR_MST_AdmissionYear_DeleteByPK(
                    AdmissionYearID,
                    Convert.ToInt32(HttpContext.Session.GetString("UserID"))
                )
            );

            if (isDeleted)
            {
                TempData["SuccessMessage"] = "Admission year successfully deleted.";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["ErrorMessage"] = "Failed to delete the admission year.";
                return RedirectToAction("Index");
            }
        }

        #endregion
    }
}
