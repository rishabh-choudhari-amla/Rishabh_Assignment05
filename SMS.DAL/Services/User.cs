using SMS.DAL.DataModel;
using SMS.DAL.IService;
using SMS.Model;
using System;
using System.Linq;

namespace SMS.DAL.Services
{
    public class User: IUser
    {
        public void SaveSignUpData(SignupDetailsTable signupDetailsTable)
        {
            using (SMSEntities datatable = new SMSEntities())
            {
                datatable.SignupDetailsTables.Add(signupDetailsTable);
                datatable.SaveChanges();
            }
        }
        public void SaveLoginCridentials(LoginTable loginTable)
        {
            using (SMSEntities datatable = new SMSEntities())
            {
                datatable.LoginTables.Add(loginTable);
                datatable.SaveChanges();
            }
        }
        public bool IsCredentialValid(LoginDetails loginDetails)
        {
            using (SMSEntities datatable = new SMSEntities())
            {
                LoginTable userData = datatable.LoginTables.FirstOrDefault(a => a.Email == loginDetails.Email);
                if (userData != null )
                {
                    if (loginDetails.Password == userData.Password)
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    return false;
                }
               
            }
        }

}
}
