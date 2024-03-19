using SMS.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.IService
{
    public interface IStandard
    {
        /// <summary>
        /// Gets Class List By Standard
        /// </summary>
        /// <param name="standard"></param>
        /// <returns>Standard Class List</returns>
        List<StudentRegistrationTable> GetClassList(string standard);

    }
}
