using SMS.DAL.DataModel;
using SMS.DAL.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Services
{
    public class LoginService: ILoginService
    {
        public bool IsAlreadyRegistered(SignupDetailsTable signupDetailsTable)
        {
            using (SMSEntities db = new SMSEntities())
            {
                return db.SignupDetailsTables.Any(a => a.Email == signupDetailsTable.Email);
            }
        }
    }
}
