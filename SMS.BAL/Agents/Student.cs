using SMS.Core;
using SMS.BAL.IAgents;
using SMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using SMS.Model.Models;
using SMS.DAL.DataModel;
using SMS.DAL.Services;
using AutoMapper;
using SMS.DAL.IService;
using System.Web.Mvc;

namespace SMS.BAL.Agents
{
    public class Student : IStudent
    {
        private readonly IStudentData studentData =DependencyResolver.Current.GetService<IStudentData>();

        private readonly IMapper _mapper;

        public Student(IMapper mapper)
        {
            _mapper = mapper;
        }
        
        #region Get Student Data
        public StudentDetails GetStudent(int userId)
        {
            StudentRegistrationTable studentRegistration= studentData.GetStudent(userId);
            return _mapper.Map<StudentDetails>(studentRegistration);
        }

        #endregion

        #region Edit Record
        public void EditRecord(StudentDetails studentDetails)
        {
           //StudentRegistrationTable studentRegistrationTable=  studentData.EditStudentData(studentDetails);
            StudentRegistrationTable studentRegistrationTable = _mapper.Map<StudentRegistrationTable>(studentDetails);
            studentData.EditStudentData(studentRegistrationTable);
        }
        #endregion

        #region Delete
        public void DeleteRecord(int userid)
        {
            studentData.DeleteStudent(userid);
        }

        #endregion

        public bool IsDateValid(DateTime date)
        {
            if (date > DateTime.Now)
            {
                return false;
            }
            return true;
        }

        public List<StudentDetails> GetStudentList()
        {
            List<StudentRegistrationTable>studentRegistrations= studentData.GetStudentList();
            List<StudentDetails> studentList = _mapper.Map<List<StudentDetails>>(studentRegistrations);
            return studentList;
        }

        public string GetName(LoginDetails loginDetails)
        {
            return studentData.GetUserName(loginDetails);
        }

        public void SaveStudentData(StudentDetails studentDetails)
        {
            StudentRegistrationTable studentRegistrationTable = _mapper.Map<StudentDetails,StudentRegistrationTable>(studentDetails);
            studentData.SaveStudentData(studentRegistrationTable);
        }

        public ReportDetails GetReport(StudentDetails student)
        {
            int Id= studentData.GetStudentByName(student);
             ResultDetailsTable result = studentData.GetStudentResultReport(Id);
           return _mapper.Map<ReportDetails>(result);
        }
    }
}
