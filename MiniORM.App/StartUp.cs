using System;
using System.Linq;
using MiniORM.App.Data;
using MiniORM.App.Data.Entities;

namespace MiniORM.App
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=.;Database=MiniORM;Integrated Security=True";

            var context = new SoftUniDbContext(connectionString);

            context.Employees.Add(new Employee
            {
               FirstName = "Mo",
               LastName = "Salah",
               DepartmentId = context.Departments.First().Id,
               IsEmployed = true
            });

            //var employee = context.Employees.Last();
            //employee.FirstName = "Zvone";
            //employee.LastName = "Boban";

            context.SaveChanges();
        }
    }
}
