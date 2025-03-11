using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.MST_User.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.MST_User.Controllers
{
    [Area("MST_User")]
    [Route("MST_User/[controller]/[action]")]

    public class MST_UserController : Controller
    {

        #region Index
        public IActionResult Index()
        {
            return View("Login");
        }
        #endregion

        #region Login
        [HttpPost]
        public IActionResult Login(MST_UserModel modelMST_User)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MST_UserDAL dalMST_User = new MST_UserDAL();
                    DataTable dtUser = dalMST_User.dbo_PR_MST_User_SelectByUserNamePassword(modelMST_User);
                    if (dtUser.Rows.Count > 0)
                    {
                        DataRow drUser = dtUser.Rows[0];

                        HttpContext.Session.SetString("UserID", drUser["UserID"]?.ToString() ?? "");
                        HttpContext.Session.SetString("UserName", drUser["UserName"]?.ToString() ?? "");
                        HttpContext.Session.SetString("Password", drUser["Password"]?.ToString() ?? "");
                        HttpContext.Session.SetString("Name", drUser["Name"]?.ToString() ?? "");

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["Error"] = "User Name or Password is invalid!<br/><br/>";
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "An error occurred: " + ex.Message;
                return RedirectToAction("Index");
            }


            return RedirectToAction("Index");
        }
        #endregion

        #region Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        #endregion
    }
}
