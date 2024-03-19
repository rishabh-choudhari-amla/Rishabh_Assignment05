using AutoMapper;
using SMS.BAL.Agents;
using SMS.BAL.IAgents;
using SMS.DAL.DataModel;
using SMS.DAL.IService;
using SMS.DAL.Services;
using SMS.Model;
using SMS.Model.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace SMS.ConfigurationManager

{
    public class AutoMapperProfile
    {
        public static void InitializeAutomapper()
        {
            var container = new UnityContainer();
            container.RegisterType<ILogin, Login>();
            container.RegisterType<IStudent, Student>();
            container.RegisterType<IRollList,RollList > ();
            container.RegisterType<ISignup,Signup>();

            container.RegisterType<ILoginService, LoginService>();
            container.RegisterType<IStandard, Standard>();
            container.RegisterType<IStudentData, StudentData>();
            container.RegisterType<IUser, User>();


            //Provide all the Mapping Configuration
            var config = new MapperConfiguration(cfg =>
            {
                //Configuring Employee and EmployeeDTO
                cfg.CreateMap<LoginDetails, LoginTable>().ReverseMap();
                cfg.CreateMap<StudentDetails, StudentRegistrationTable>().ReverseMap();
                cfg.CreateMap<SignupDetails, SignupDetailsTable>().ReverseMap();
                cfg.CreateMap<ReportDetails, ResultDetailsTable>().ReverseMap();
                //Any Other Mapping Configuration ....
            });
            //Create an Instance of Mapper and return that Instance

            container.RegisterInstance(config.CreateMapper());
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}

