using System;
using System.Collections.Generic;
using System.Linq;
using SMS.Model.Models;
using System.Web.Mvc;
using SMS.BAL;
using SMS.BAL.IAgents;
using SMS.BAL.Agents;
using SMS.CustomResource;
using AutoMapper;
using SMS.Model;

namespace SMS.Controllers
{

    public class ResultController : Controller
    {
        private readonly IRollList rollList ;
        private readonly IStudent _student;
        public ResultController()
        {
            rollList = DependencyResolver.Current.GetService<IRollList>();
            _student= DependencyResolver.Current.GetService<IStudent>();
        }
        #region Student Select
        public ActionResult StudentSelect()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudentSelect(StudentDetails studentDetails)
        {
            ModelState.Remove("Id");
            ModelState.Remove("Email");
            ModelState.Remove("PhoneNumber");
            ModelState.Remove("Gender");
            ModelState.Remove("City");
            ModelState.Remove("DateOfBirth");

            if (!ModelState.IsValid)
            {
                return View(ResourceFile.ResultView, _student.GetReport(studentDetails));
            }
            else
            {
                return View();
            }
        }
        #endregion
    }
}