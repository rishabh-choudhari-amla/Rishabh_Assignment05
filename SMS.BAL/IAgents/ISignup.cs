using SMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BAL.IAgents
{
    public interface ISignup
    {
        /// <summary>
        /// Save User Signup details
        /// </summary>
        /// <param name="signupDetails"></param>
        /// <returns>return status of saving</returns>
        bool saveDetails(SignupDetails signupDetails);

        /// <summary>
        /// Fetchs firstname from email 
        /// </summary>
        /// <param name="loginDetails"></param>
        /// <returns>name of user</returns>
        string GetUserName(LoginDetails loginDetails);

        /// <summary>
        /// Save Login Details
        /// </summary>
        /// <param name="loginDetails"></param>
        void SaveLoginDetails(LoginDetails loginDetails);
    }
}
