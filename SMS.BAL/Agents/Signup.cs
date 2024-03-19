using AutoMapper;
using SMS.BAL.IAgents;
using SMS.Core;
using SMS.DAL.DataModel;
using SMS.DAL.IService;
using SMS.DAL.Services;
using SMS.Model;
using System;
using System.Web.Mvc;

namespace SMS.BAL.Agents
{
    public class Signup:ISignup
    {
        private readonly IMapper _mapper;
        private readonly IUser user = DependencyResolver.Current.GetService<IUser>();
        public Signup(IMapper mapper)
        {
            _mapper = mapper;
        }
       
        public virtual bool saveDetails(SignupDetails signupDetails)
        {
            SignupDetailsTable signupDetailsTable = _mapper.Map<SignupDetailsTable>(signupDetails);
            user.SaveSignUpData(signupDetailsTable);
            return true;
        }
        public string GetUserName(LoginDetails loginDetails)
        {

            int index = AdminList.signupDetailsList.FindIndex(x => x.Email == loginDetails.Email);
            return AdminList.signupDetailsList[index].FirstName;
        }
        
        public void SaveLoginDetails(LoginDetails loginDetails)
        {
            LoginTable loginTable = _mapper.Map<LoginTable>(loginDetails);
            user.SaveLoginCridentials(loginTable);
        }

    }
}
