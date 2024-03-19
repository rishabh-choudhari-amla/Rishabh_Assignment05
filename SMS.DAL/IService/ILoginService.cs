using SMS.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.IService
{
    public interface ILoginService
    {
        /// <summary>
        /// Checks If Email Already Registered
        /// </summary>
        /// <param name="signupDetailsTable"></param>
        /// <returns></returns>
        bool IsAlreadyRegistered(SignupDetailsTable signupDetailsTable);
    }
}
