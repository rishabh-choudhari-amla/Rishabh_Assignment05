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
    public interface IRollList
    {
        /// <summary>
        /// Displays RollList of standard 
        /// </summary>
        /// <param name="standard"></param>
        List<StudentDetails> GetRollList(string standard);

        /// <summary>
        /// Update Records in the Report List
        /// </summary>
        /// <param name="reportDetails"></param>
        void UpdateRecord(ReportDetails reportDetails);

        /// <summary>
        /// Calculate Percentage by given Marks 
        /// </summary>
        /// <param name="reportDetails"></param>
        /// <returns>percentage</returns>
        double GetPercentage(ReportDetails reportDetails);

        /// <summary>
        /// Fetch Student Report Data by StudentId
        /// </summary>
        /// <param name="StudentId"></param>
        /// <returns></returns>
        ReportDetails GetStudentReport(StudentDetails studentDetails);


    }
}
