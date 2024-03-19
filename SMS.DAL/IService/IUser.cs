using SMS.DAL.DataModel;
using SMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.IService
{
    public interface IUser
    {
        /// <summary>
        /// Save Signup Details for login 
        /// </summary>
        /// <param name="signupDetailsTable"></param>
        void SaveSignUpData(SignupDetailsTable signupDetailsTable);

        /// <summary>
        /// Save Login Details
        /// </summary>
        /// <param name="loginTable"></param>

        void SaveLoginCridentials(LoginTable loginTable);

        /// <summary>
        /// Checks Login Details are valid or not
        /// </summary>
        /// <param name="loginDetails"></param>
        /// <returns></returns>

        bool IsCredentialValid(LoginDetails loginDetails);
    }
}
