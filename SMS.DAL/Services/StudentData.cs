using SMS.DAL.DataModel;
using SMS.DAL.IService;
using SMS.Model;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace SMS.DAL.Services
{
    public class StudentData: IStudentData
    {
        public List<StudentRegistrationTable> GetStudentList()
        {
            using (SMSEntities students = new SMSEntities())
            {
                StudentRegistrationTable student = new StudentRegistrationTable();
                if (student != null)
                {
                    return students.StudentRegistrationTables.ToList();
                }
                return null;
            }
        }

        public string GetUserName(LoginDetails loginDetails)
        {
            using (SMSEntities students = new SMSEntities())
            {
                SignupDetailsTable student = students.SignupDetailsTables.FirstOrDefault(a => a.Email == loginDetails.Email);
                if (student != null)
                {
                    return student.FirstName;
                }
                return null;
            }
        }


        public StudentRegistrationTable GetStudent(int Id)
        {
            using (SMSEntities students = new SMSEntities())
            {
                StudentRegistrationTable student = students.StudentRegistrationTables.FirstOrDefault(a => a.Id == Id);
                if (student != null)
                {
                    return student;
                }
                return null;
            }
        }

        public void SaveStudentData(StudentRegistrationTable studentRegistrationTable)
        {
            using (SMSEntities students = new SMSEntities())
            {
                StudentRegistrationTable tableData = studentRegistrationTable;
                students.StudentRegistrationTables.Add(tableData);
                students.SaveChanges();
            }
        }

        public bool EditStudentData(StudentRegistrationTable studentRegistrationTable)
        {
            if (studentRegistrationTable == null) return false;
            using (SMSEntities students = new SMSEntities())
            {
                StudentRegistrationTable student = students.StudentRegistrationTables.FirstOrDefault(a => a.Id == studentRegistrationTable.Id);
                student = studentRegistrationTable;
                var result =students.StudentEdit(student.Id,
                    student.Email, 
                    student.FirstName,
                    student.LastName,
                    student.Gender,
                    student.PhoneNumber,
                    student.Address,
                    student.DateOfBirth,
                    student.Standard,
                    student.City);
                students.SaveChanges();
                return true;
            }
        }
        public void DeleteStudent(int Id)
        {
            using (SMSEntities students = new SMSEntities())
            {
                int isDeleted = students.DELETESTUDENT(Id);
                students.SaveChanges();
            }
        }

        public void AddReport(ResultDetailsTable report)
        {
            using(SMSEntities reportData = new SMSEntities())
            {
                reportData.ResultDetailsTables.Add(report);
                reportData.SaveChanges();
            }
        }

        public ResultDetailsTable GetStudentResultReport(int Id)
        {
            using (SMSEntities studentReport = new SMSEntities())
            {
                ResultDetailsTable studentResult = studentReport.ResultDetailsTables.FirstOrDefault(entry => entry.Id== Id);
                return studentResult;
            }
           
        }

        public int GetStudentByName(StudentDetails student)
        {
            using (SMSEntities studentReport = new SMSEntities())
            {
                StudentRegistrationTable studentResult = studentReport.StudentRegistrationTables.FirstOrDefault(entry => entry.FirstName == student.FirstName && entry.LastName==student.LastName&&entry.Standard==student.Standard);
                return studentResult.Id;
            }
        }
    }
}
