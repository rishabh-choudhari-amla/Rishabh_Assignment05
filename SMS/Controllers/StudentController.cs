using AutoMapper;
using SMS.BAL.Agents;
using SMS.BAL.IAgents;
using SMS.Core;
using SMS.CustomResource;
using SMS.Model;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SMS.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private readonly IStudent _student;

        public StudentController()
        {
            _student = DependencyResolver.Current.GetService<IStudent>();
        }

        #region Add Student
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View(new StudentDetails());
        }

        [HttpPost]
        public ActionResult AddStudent(StudentDetails studentDetails)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _student.SaveStudentData(studentDetails);
                    TempData[ResourceFile.Added] = ResourceFile.StudentAdded;
                    return RedirectToAction("StudentList", _student.GetStudentList());//ResourceFile.StudentList
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View(ResourceFile.Error);
            }
        }

        #endregion

        #region List View
        [Authorize]
        [HttpGet]
        public ActionResult StudentList()
        {
            return View(_student.GetStudentList());
        }
        #endregion

        #region Edit Student Details
        [HttpGet]
        public ActionResult EditStudent(int userId)
        {
            StudentDetails student = _student.GetStudent(userId);
            if (student == null)
            {
                TempData["Error"] = "Record Not Found";
                return View("Error");
            }
            return View("AddStudent",student);
        }

        [HttpPost]
        public ActionResult EditStudent(StudentDetails studentDetails)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _student.EditRecord(studentDetails);
                    TempData[ResourceFile.Edited] = ResourceFile.EditedSuccessfully;
                    return RedirectToAction(ResourceFile.StudentList);
                }
                else
                {
                    return View("AddStudent", studentDetails);
                }
            }
            catch { return View(ResourceFile.Error); }
        }
        #endregion

        #region Delete Student
        public ActionResult DeleteStudent(int userId)
        {
            try
            {
                _student.DeleteRecord(userId);
                TempData[ResourceFile.Deleted] = ResourceFile.DeletedSuccessfully;
                return RedirectToAction(ResourceFile.StudentList);
            }
            catch { return View(ResourceFile.Error); }
        }

        #endregion

        #region Details

        public ActionResult StudentDetails(int userId)
        {
            StudentDetails student = _student.GetStudent(userId);
            if (student == null)
            {
                TempData["Error"] = "Record Not Found";
                return View("Error");
            }
            return View(student);
        }

        #endregion

    }
}