using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.BusinessLogic.Abstracts
{
    public interface IEmployeeInterface
    {

        /// <summary>
        /// Create a Project.
        /// </summary>
        /// <param > Request.</param>
        /// <returns> Response.</returns>
        string Test(string project);
    }
}
