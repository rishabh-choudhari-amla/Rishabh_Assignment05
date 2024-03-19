using AutoMapper;
using SMS.BAL.IAgents;
using SMS.Core;
using SMS.DAL.DataModel;
using SMS.DAL.IService;
using SMS.DAL.Services;
using SMS.Model;
using SMS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SMS.BAL.Agents
{
    public class RollList:IRollList
    {
        IStudentData studentData = DependencyResolver.Current.GetService<IStudentData>();
        IStandard _standardList = DependencyResolver.Current.GetService<IStandard>();
        private readonly IMapper _mapper;

        public RollList(IMapper mapper)
        {
            _mapper = mapper;
        }

       
        Standard standardList = new Standard();
        public List<StudentDetails> GetRollList(string standard)
        {
           List<StudentRegistrationTable>studentList= _standardList.GetClassList(standard);
           List<StudentDetails> classList= _mapper.Map<List<StudentDetails>>(studentList);
           return classList;
        }

        public void UpdateRecord(ReportDetails reportDetails)
        {
            reportDetails.Percentage=Math.Round(GetPercentage(reportDetails),2);
            if(reportDetails.Percentage>=33)
            {
                reportDetails.Result = "Pass";
            }
            else
            {
                reportDetails.Result = "Fail";
            }
            studentData.AddReport(_mapper.Map<ResultDetailsTable>(reportDetails));
        }
        public double GetPercentage(ReportDetails reportDetails)
        {
            double total = reportDetails.Maths+reportDetails.EVS+reportDetails.Science+reportDetails.Hindi+reportDetails.English;
            return total/600;
        }
        public ReportDetails GetStudentReport(StudentDetails studentDetails)
        {
           ResultDetailsTable student= studentData.GetStudentResultReport(studentDetails.Id);  

            return _mapper.Map<ReportDetails>(student);
        }

    }
}
