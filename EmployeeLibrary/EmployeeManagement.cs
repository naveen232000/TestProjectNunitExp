using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class EmployeeManagement
    {
        static List<Employee> list = new List<Employee>() { 
        new Employee(){Id=1,Name="Sam",Salary=65329,Doj=new DateTime(day:23,month:02,year:2023)},
        new Employee(){Id=2,Name="Jon",Salary=54123,Doj=new DateTime(day:12,month:12,year:2023)},
        new Employee(){Id=3,Name="Ram",Salary=32657,Doj=new DateTime(day:03,month:09,year:2023)},
        new Employee(){Id=4,Name="Leo",Salary=26545,Doj=new DateTime(day:15,month:10,year:2023)},
        new Employee(){Id=5,Name="Das",Salary=45321,Doj=new DateTime(day:16,month:02,year:2024)},
        };
   
    public List<Employee> AllEmp()
    {
        return list;
    }
    public List<Employee> SearchEmp(int id) {
    List<Employee> emp = list.FindAll(x=>x.Id==id);
        return emp;
    }
    }
}
