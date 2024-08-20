using KeyStoneCodeFirst_BusinessEntities.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneCodeFirst_BusinessEntities.InterFace
{
    public interface IEmployeeService
    {
        List<EmployeeDTO> GetAllEmployeeDetails();
       List<EmployeeDTO> GetEmployeeDetailsByID(int id);
        bool AddEmployeeDetails(EmployeeDTO employeeDTO);
        bool UpdateEmployeeDetails(EmployeeDTO employeeDTO);
        bool DeleteEmployeeDetails(int id);
    }
}
