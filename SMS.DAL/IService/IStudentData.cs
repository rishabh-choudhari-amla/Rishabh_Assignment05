using SMS.DAL.DataModel;
using SMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.IService
{
    public interface IStudentData
    {
        /// <summary>
        /// Get Student List From School Table
        /// </summary>
        /// <returns>Student List</returns>
        List<StudentRegistrationTable> GetStudentList();

        /// <summary>
        /// Gets UserName From Login Email
        /// </summary>
        /// <param name="loginDetails"></param>
        /// <returns>string Name</returns>
        string GetUserName(LoginDetails loginDetails);

        /// <summary>
        /// Get Student Details From ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Student Details</returns>
        StudentRegistrationTable GetStudent(int Id);

        /// <summary>
        /// Save Student Record in Database
        /// </summary>
        /// <param name="studentRegistrationTable"></param>
        void SaveStudentData(StudentRegistrationTable studentRegistrationTable);

        /// <summary>
        /// Edit Student Record 
        /// </summary>
        /// <param name="studentRegistrationTable"></param>
        /// <returns></returns>
        bool EditStudentData(StudentRegistrationTable studentRegistrationTable);

        /// <summary>
        /// Delete Student From Database record
        /// </summary>
        /// <param name="Id"></param>
        void DeleteStudent(int Id);

        /// <summary>
        /// Add Result of Student Result
        /// </summary>
        /// <param name="report"></param>
        void AddReport(ResultDetailsTable report);

        /// <summary>
        /// Get Student Result From Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Student result</returns>
        ResultDetailsTable GetStudentResultReport(int Id);

        /// <summary>
        /// Gets Student Id From Name
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Student ID</returns>
        int GetStudentByName(StudentDetails student);
    }
}
