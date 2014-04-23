using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Monitor.Entities;
using Hotel.Monitor.Repositories;

namespace Hotel.Monitor.BLL
{
    public class EmployeeBase
    {
        Repository.IRepository<Employee> employeeRep;
        public EmployeeBase()
        {
            employeeRep = RepositoryUnitOfWork.Instance.GetRepository<Employee>();
        }



        public Employee CreateEmployee(Employee emp)
        {
           return  employeeRep.Create(emp);
        }

        public ICollection<Employee> GetEmployees()
        {
            return employeeRep.All().ToList();
        }

        public Employee GetEmployeeByUserName(string userName)
        {
            return employeeRep.All().FirstOrDefault(e => e.UserName == userName);
        }
    }
}
