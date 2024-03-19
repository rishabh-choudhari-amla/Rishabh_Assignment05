using SMS.DAL.DataModel;
using SMS.DAL.IService;
using SMS.Model.ViewModels;
using SMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Services
{
    public  class Standard: IStandard
    {
        public List<StudentRegistrationTable> GetClassList(string standard)
        {
            using (SMSEntities classList = new SMSEntities())
            {
                List<StudentRegistrationTable> studentList = classList.StudentRegistrationTables.Where(t => t.Standard == standard).ToList();
                return studentList;
            }
        }

        

    }
}
