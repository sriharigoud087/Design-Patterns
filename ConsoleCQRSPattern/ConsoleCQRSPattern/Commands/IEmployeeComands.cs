using ConsoleCQRSPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCQRSPattern.Commands
{
    public interface IEmployeeComands
    {
        void SaveEmployeeData(Employee employee);
    }
}
