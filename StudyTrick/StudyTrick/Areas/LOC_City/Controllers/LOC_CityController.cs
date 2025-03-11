using Microsoft.AspNetCore.Mvc;
using StudyTrick.Areas.LOC_City.Models;
using StudyTrick.Areas.LOC_State.Models;
using StudyTrick.DAL;
using System.Data;

namespace StudyTrick.Areas.LOC_City.Controllers
{
    [Area("LOC_City")]
    [Route("LOC_City/[controller]/[action]")]
    public class LOC_CityController : Controller
    {
        #region Add
        public IActionResult Add(int? CityID)
        {
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

            #region Select By PK
            if (CityID != null)
            {
                LOC_CityDAL dalLOC_City = new LOC_CityDAL();
                DataTable dtCity = dalLOC_City.dbo_PR_LOC_City_SelectByPK(CityID, Convert.ToInt32(HttpContext.Session.GetString("UserID")));

                LOC_CityModel modelLOC_City = new LOC_CityModel();
                foreach (DataRow drCity in dtCity.Rows)
                {
                    modelLOC_City.StateID = Convert.ToInt32(drCity["StateID"]);
                    modelLOC_City.CityName = drCity["CityName"].ToString();
                    modelLOC_City.Description = drCity["Description"].ToString();
                }
                TempData["CitySaveMSG"] = "Edit";

                return View("LOC_CityAddEdit", modelLOC_City);
            }
            #endregion

            TempData["CitySaveMSG"] = "Add";

            return View("LOC_CityAddEdit");
        }
        #endregion

        #region Insert
        public IActionResult Save(LOC_CityModel modelLOC_City)
        {
            LOC_CityDAL dalLOC_City = new LOC_CityDAL();

            if (ModelState.IsValid)
            {
                if (modelLOC_City.CityID == null)
                {
                    dalLOC_City.dbo_PR_LOC_City_Insert(modelLOC_City, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
                else
                {
                    dalLOC_City.dbo_PR_LOC_City_UpdateByPK(modelLOC_City, Convert.ToInt32(HttpContext.Session.GetString("UserID")));
                }
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Select All
        public IActionResult Index()
        {
            LOC_CityDAL dalLOC_City = new LOC_CityDAL();

            DataTable dtCity = dalLOC_City.dbo_PR_LOC_City_SelectAll(Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            return View("LOC_CityList", dtCity);
        }
        #endregion

        #region Delete By PK
        public IActionResult Delete(int CityID)
        {
            LOC_CityDAL dalLOC_City = new LOC_CityDAL();
            if (Convert.ToBoolean(dalLOC_City.dbo_PR_LOC_City_DeleteByPK(CityID, Convert.ToInt32(HttpContext.Session.GetString("UserID")))))
                return RedirectToAction("Index");

            return View("LOC_CityList");
        }
        #endregion
    }
}
