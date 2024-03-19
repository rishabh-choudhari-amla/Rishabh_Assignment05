using SMS.Model;
using SMS.Model.Models;
using System.Collections.Generic;

namespace SMS.Core
{
    public class StudentListFile
    {
        public static List<StudentDetails> studentList = new List<StudentDetails>
        {
        };

    }
    public class RollListFile
    {
        public static List<StudentDetails> rollList = new List<StudentDetails>();

    }

    public class GenderListFile
    {
        public static List<string> genderList = new List<string> { "Male", "Female","Other"};

    }
    public class StandardListFile
    {
        public static List<string> standardList = new List<string> { "First", "Second", "Third","Fourth","Fifth" };

    }
    public class DesignationListFile
    {
        public static List<string> designationList = new List<string> { "Staff", "Teacher", "Incharge","Manager" };

    }
    public class ReportList
    {
        public static List<ReportDetails> reportList = new List<ReportDetails>();
    }
    public class LoginList
    {
        public static Dictionary<string, string> UserLoginDictionary = new Dictionary<string, string>
        { 
            {"admin", "admin"},
        };
    }

    public class IdList
    {
        public static Dictionary<string, string> StudentIdList = new Dictionary<string, string>();
    }

    public class AdminList
    {
        public static List<SignupDetails> signupDetailsList= new List<SignupDetails>();
    }
   public enum Gender
    {
        male,
        female,
        other
    }
}
