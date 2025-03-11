using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.LOC_State.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.LOC_State.Controllers
{
    [Area("LOC_State")]
    [Route("LOC_State/[controller]/[action]")]

    public class LOC_StateController : Controller
    {
        public LOC_StateController() { }

        #region Add
        public IActionResult Add(int? StateID)
        {
            #region Select By PK
            if (StateID != null)
            {
                LOC_StateDAL dalLOC_State = new LOC_StateDAL();
                DataTable dtState = dalLOC_State.dbo_PR_LOC_State_SelectByPK(StateID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                LOC_StateModel modelLOC_State = new LOC_StateModel();

                foreach (DataRow dr in dtState.Rows)
                {
                    modelLOC_State.StateID = Convert.ToInt32(dr["StateID"]);
                    modelLOC_State.StateName = dr["StateName"].ToString();
                    modelLOC_State.Description = dr["Description"].ToString();
                }
                TempData["StateInsertMSG"] = "Edit";

                return View("LOC_StateAddEdit", modelLOC_State);
            }
            TempData["StateInsertMSG"] = "Add";

            #endregion

            return View("LOC_StateAddEdit");
        }
        #endregion

        #region Insert
        [HttpPost]
        public IActionResult Save(LOC_StateModel modelLOC_State)
        {
            LOC_StateDAL dalLOC_State = new LOC_StateDAL();

            if (ModelState.IsValid)
            {
                if (modelLOC_State.StateID == null)
                {
                    dalLOC_State.dbo_PR_LOC_State_Insert(modelLOC_State, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
                else
                {
                    dalLOC_State.dbo_PR_LOC_State_UpdateByPK(modelLOC_State, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
            }
            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            LOC_StateDAL dalLOC_State = new LOC_StateDAL();

            DataTable dt = dalLOC_State.dbo_PR_LOC_State_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));

            return View("LOC_StateList", dt);
        }
        #endregion

        #region Delete By PK
        public IActionResult Delete(int StateID)
        {
            LOC_StateDAL dalLOC_State = new LOC_StateDAL();

            if (Convert.ToBoolean(dalLOC_State.dbo_PR_LOC_State_DeleteByPK(StateID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("LOC_StateList");
        }
        #endregion
    }
}
