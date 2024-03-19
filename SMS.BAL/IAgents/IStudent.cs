using SMS.DAL.DataModel;
using SMS.Model;
using SMS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BAL.IAgents
{
    public interface IStudent
    {

        /// <summary>
        /// Fetchs Student record from list by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        StudentDetails GetStudent(int id);

        /// <summary>
        /// Edits student record 
        /// </summary>
        /// <param name="studentDetails"></param>
        /// <returns>return standard list </returns>
        void EditRecord(StudentDetails studentDetails);
        
        /// <summary>
        /// Delete student record by ID
        /// </summary>
        /// <param name="userid"></param>
        void DeleteRecord(int userid);

        /// <summary>
        /// Check if input date is past or not
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        bool IsDateValid(DateTime date);

        /// <summary>
        /// Get Student List in School 
        /// </summary>
        /// <returns>All Student List</returns>
        List<StudentDetails> GetStudentList();

        /// <summary>
        /// Save Data in Table 
        /// </summary>
        /// <param name="studentDetails"></param>
        void SaveStudentData(StudentDetails studentDetails);

        /// <summary>
        /// Get User Name From Email
        /// </summary>
        /// <param name="loginDetails"></param>
        /// <returns></returns>
        string GetName(LoginDetails loginDetails);

        /// <summary>
        /// Get Student Result Report from Student Id
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        ReportDetails GetReport(StudentDetails student);
    }
}
