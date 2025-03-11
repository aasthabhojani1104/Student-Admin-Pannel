using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using StudyTrick.Areas.MST_Staff.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.MST_Staff.Controllers
{
    [Area("MST_Staff")]
    [Route("MST_Staff/[controller]/[action]")]
    public class MST_StaffController : Controller
    {
        #region Add
        public IActionResult Add(int? StaffID)
        {
            #region Select By PK
            if (StaffID != null)
            {
                MST_StaffDAL dalMST_Staff = new MST_StaffDAL();
                DataTable dtStaff = dalMST_Staff.dbo_PR_MST_Staff_SelectByPK(StaffID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                MST_StaffModel modelMST_Staff = new MST_StaffModel();
                foreach (DataRow drStaff in dtStaff.Rows)
                {
                    modelMST_Staff.StaffID = Convert.ToInt32(drStaff["StaffID"]);
                    modelMST_Staff.StaffName = drStaff["StaffName"].ToString();
                    modelMST_Staff.Phone = drStaff["Phone"].ToString();
                    modelMST_Staff.Email = drStaff["Email"].ToString();
                    modelMST_Staff.StaffCode = drStaff["StaffCode"].ToString();
                    modelMST_Staff.Description = drStaff["Description"].ToString();
                }
                TempData["StaffSaveMSG"] = "Edit";

                return View("MST_StaffAddEdit", modelMST_Staff);
            }
            #endregion

            TempData["StaffSaveMSG"] = "Add";

            return View("MST_StaffAddEdit");
        }
        #endregion

        #region Save
        public IActionResult Save(MST_StaffModel modelMST_Staff)
        {
            MST_StaffDAL dalMST_Staff = new MST_StaffDAL();
            if (ModelState.IsValid)
            {
                if (modelMST_Staff.StaffID == null)
                    dalMST_Staff.dbo_PR_MST_Staff_Insert(modelMST_Staff, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                else
                    dalMST_Staff.dbo_PR_MST_Staff_UpdateByPK(modelMST_Staff, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            MST_StaffDAL dalMST_Staff = new MST_StaffDAL();
            DataTable dtStaff = dalMST_Staff.dbo_PR_MST_Staff_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("MST_StaffList", dtStaff);
        }
        #endregion

        #region Delete By PK
        public IActionResult Delete(int StaffID)
        {
            MST_StaffDAL dalMST_Staff = new MST_StaffDAL();
            if (Convert.ToBoolean(dalMST_Staff.dbo_PR_MST_Staff_DeleteByPK(StaffID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("MST_StaffList");
        }
        #endregion
    }
}
