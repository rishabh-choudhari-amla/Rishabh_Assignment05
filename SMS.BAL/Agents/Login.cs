using AutoMapper;
using SMS.BAL.IAgents;
using SMS.Core;
using SMS.DAL.DataModel;
using SMS.DAL.IService;
using SMS.DAL.Services;
using SMS.Model;
using System.Linq;
using System.Web.Mvc;

namespace SMS.BAL.Agents
{
    public class Login : ILogin
    {

        private readonly IMapper _mapper;

        private ILoginService loginService = DependencyResolver.Current.GetService<ILoginService>();


        public Login(IMapper mapper)
        {
            _mapper = mapper;
        }


        public bool IsCredentialValid(LoginDetails loginDetails)
        {
            if (loginDetails == null)
            {
                return false;
            }
            else
            {
                User user = new User();
                return user.IsCredentialValid(loginDetails);
            }

        }

        public bool IsAlreadyExist(SignupDetails signupDetails)
        {
            if (signupDetails != null)
            {
                SignupDetailsTable signupDetailsTable = _mapper.Map<SignupDetailsTable>(signupDetails);
                return loginService.IsAlreadyRegistered(signupDetailsTable);
            }
            return false;
        }

        public bool IsCridentialsValid(SignupDetails signupDetails)
        {
            throw new System.NotImplementedException();
        }
    }
}
