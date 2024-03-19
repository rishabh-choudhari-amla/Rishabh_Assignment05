using SMS.BAL.Agents;
using SMS.BAL.IAgents;
using SMS.Core;
using SMS.CustomResource;
using SMS.DAL.Services;
using SMS.Model;
using SMS.Model.Models;
using SMS.Model.ViewModels;
using System.Collections.Generic;
using System.Security;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using StandardList = SMS.Model.ViewModels.StandardList;

namespace SMS.Controllers
{
    
    public class ClassController : Controller
    {
        IRollList _rollList;
        public ClassController()
        {
            _rollList = DependencyResolver.Current.GetService<IRollList>();
        }

        #region Class Wise Listing
        [Authorize]
        public ActionResult ClassList()
        {
            return View(new StandardList());
        }
        [HttpPost]
        public ActionResult ClassList(StandardList standardList)
        {
            try { 
            List<StudentDetails> list=_rollList.GetRollList(standardList.Standard);
            return View(ResourceFile.RollList, list);
            }
            catch { return View(ResourceFile.Error); }
        }
        [Authorize]
        public ActionResult RollList(List<StudentDetails> list)
        {
            return View(list);
        }

        public ActionResult ReportClassList()
        {
            return View("ClassList");
        }
        [HttpPost]
        public ActionResult ReportClassList(StandardList standardList)
        {
            try
            {
                List<StudentDetails> list = _rollList.GetRollList(standardList.Standard);
                return View(list);
            }
            catch { return View(ResourceFile.Error); }
        }
        public ActionResult ReportRollList(List<StudentDetails> list)
        {
            return View("ClassList");
        }

        #endregion
        #region Marks Entry
        [Authorize]
        
        public ActionResult EnterMarks(int userid)
        {
            return View(new ReportDetails() { Id=userid });
        }
        [HttpPost]
        public ActionResult EnterMarks(ReportDetails report)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _rollList.UpdateRecord(report);
                    TempData["Marks"] = "Marks Entered Successfully";
                    return RedirectToAction(ResourceFile.ReportRollList);
                }
                catch
                {
                    return View(ResourceFile.Error);
                }
            }
            else
            {
                return View();
            }
        }
        #endregion


    }
}