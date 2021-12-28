using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var softuniContext = new SoftUniContext();
            //var result = GetEmployeesFullInformation(softuniContext);           
            //var result = GetEmployeesWithSalaryOver50000(softuniContext);
            //var result = GetEmployeesFromResearchAndDevelopment(softuniContext);
            //var result = AddNewAddressToEmployee(softuniContext);
            //var result = GetEmployeesInPeriod(softuniContext);
            //var result = GetEmployee147(softuniContext);
            //var result = GetAddressesByTown(softuniContext);
            //var result = GetDepartmentsWithMoreThan5Employees(softuniContext);
            //var result = IncreaseSalaries(softuniContext);
            //var result = GetEmployeesByFirstNameStartingWithSa(softuniContext);
            //var result = RemoveTown(softuniContext);
            var result = DeleteProjectById(softuniContext);
            
            Console.WriteLine(result);

        }

        //Problem 3
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Select(e => new
                {
                    e.EmployeeId,
                    e.FirstName,
                    e.MiddleName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.EmployeeId)
                .ToList();

            foreach (var e in employees)
            {
                if (e.MiddleName == null)
                {
                    sb.AppendLine($"{e.FirstName} {e.LastName} {e.JobTitle} {e.Salary:F2}");
                }
                else
                {

                    sb.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:F2}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 4
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var emplouees = context.Employees
                .Select(x => new
                {
                    x.FirstName,
                    x.Salary
                })
                .Where(x => x.Salary > 50000)
                .OrderBy(n => n.FirstName)
                .ToList();


            var sb = new StringBuilder();

            foreach (var item in emplouees)
            {
                sb.AppendLine($"{item.FirstName} - {item.Salary:f}");
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 5
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var emplouees = context.Employees
                .Where(x => x.Department.Name == "Research and Development")
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    DepartmentName = x.Department.Name,
                    x.Salary,
                })
                .OrderBy(x => x.Salary)
                .ThenByDescending(x => x.FirstName)
                .ToList();

            var sb = new StringBuilder();

            foreach (var item in emplouees)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName} from {item.DepartmentName} - ${item.Salary:f}");
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 6
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var nakov = context.Employees.FirstOrDefault(x => x.LastName == "Nakov");
            nakov.Address = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.SaveChanges();


            var empliueesTopTen = context.Employees
                .Select(x => new
                {
                    x.Address.AddressText,
                    x.Address.AddressId
                })
                .OrderByDescending(x => x.AddressId)
                .Take(10)
                .ToList();

            var sb = new StringBuilder();

            foreach (var item in empliueesTopTen)
            {
                sb.AppendLine($"{item.AddressText}");
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 7
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {

            var employees = context.Employees
                .Where(x => x.EmployeesProjects
                .Any(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003))
                .Select(x => new
                {
                    FirstNameEmployee = x.FirstName,
                    LastNameEmployee = x.LastName,
                    FirstNameMAnager = x.Manager.FirstName,
                    LastNameManager = x.Manager.LastName,
                    Projects = x.EmployeesProjects.Select(p => new
                    {
                        ProjectName = p.Project.Name,
                        ProjectStartDate = p.Project.StartDate,
                        ProjectpEndDate = p.Project.EndDate
                    })
                })
                .Take(10)
                .ToList();


            var sb = new StringBuilder();

            foreach (var items in employees)
            {
                sb.AppendLine($"{items.FirstNameEmployee} {items.LastNameEmployee} " +
                    $"- Manager: {items.FirstNameMAnager} {items.LastNameManager}");

                foreach (var item in items.Projects)
                {

                    if(item.ProjectpEndDate == null)
                    {
                        sb.AppendLine($"--{item.ProjectName} " +
                            $"- {item.ProjectStartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - not finished");
                    }
                    else
                    {
                        sb.AppendLine($"--{item.ProjectName} " +
                            $"- {item.ProjectStartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} " +
                            $"- {item.ProjectpEndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
                    }
                }
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 8
        public static string GetEmployee147(SoftUniContext context)
        {
            var employee147 = context.Employees
                .Select(x => new
                {
                    x.EmployeeId,
                    x.FirstName,
                    x.LastName,
                    x.JobTitle,
                    Projects = x.EmployeesProjects.Select(x => new
                    {
                        ProjectName = x.Project.Name
                    })
                  .OrderBy(x => x.ProjectName).ToList()
                }).FirstOrDefault(x => x.EmployeeId == 147);


            var sb = new StringBuilder();
          
                sb.AppendLine($"{employee147.FirstName} {employee147.LastName} - {employee147.JobTitle}");

                foreach (var project in employee147.Projects)
                {
                    sb.AppendLine($"{project.ProjectName}");
                }       
            

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 9
        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                .Select(x => new
                {
                    addresText = x.AddressText,
                    townName = x.Town.Name,
                    EmployeesCOUNT = x.Employees.Count
                }).OrderByDescending(x => x.EmployeesCOUNT)
                  .ThenBy(x => x.townName)
                  .ThenBy(x => x.addresText)
                  .Take(10)
                  .ToList();

            var sb = new StringBuilder();

            foreach (var address in addresses)
            {
                sb.AppendLine($"{address.addresText}, {address.townName} - {address.EmployeesCOUNT} employees");
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 10
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context.Departments
                .Where(x => x.Employees.Count > 5)
                .OrderBy(x => x.Employees.Count)
                .ThenBy(x => x.Name).Select(x => new
                {
                    DepartmentName = x.Name,
                    ManagerFirstName = x.Manager.FirstName,
                    ManagerLastName = x.Manager.LastName,
                    EmployeesList = x.Employees.Select(e => new
                    {
                        employeeFirstName = e.FirstName,
                        employeeLastName = e.LastName,
                        employeeJobtitle = e.JobTitle,
                    }).OrderBy(e => e.employeeFirstName)
                      .ThenBy(e => e.employeeLastName)
                      .ToList()
                });


            var sb = new StringBuilder();

            foreach (var employees in departments)
            {
                sb.AppendLine($"{employees.DepartmentName} - {employees.ManagerFirstName} {employees.ManagerLastName}");

                foreach (var employee in employees.EmployeesList)
                {
                    sb.AppendLine($"{employee.employeeFirstName} {employee.employeeLastName} - {employee.employeeJobtitle}");
                }
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 11
        public static string IncreaseSalaries(SoftUniContext context)
        {
            List<string> departments = new List<string> { "Engineering", "Tool Design", "Marketing", "Information Services" };

            var employees = context.Employees
                .Where(x => departments.Contains(x.Department.Name))
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();


            foreach (var employee in employees)
            {
                employee.Salary *= 1.12m;
            }

            context.SaveChanges();

                  
            var sb = new StringBuilder();

            foreach (var emp in employees)
            {
                sb.AppendLine($"{emp.FirstName} {emp.LastName} (${emp.Salary:f2})");
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 12
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(x => EF.Functions.Like(x.FirstName, "sa%"))
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    x.JobTitle,
                    x.Salary
                })
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            var sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} " +
                    $"- {employee.JobTitle} - (${employee.Salary:f2})");
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 13
        public static string RemoveTown(SoftUniContext context)
        {
            var addressIdsToRemove = context.Addresses
               .Where(a => a.Town.Name == "Seattle")
               .Select(a => a.AddressId)
               .ToList();

            var employees = context.Employees
                .ToList();

            foreach (var id in addressIdsToRemove)
            {
                foreach (var emp in employees)
                {
                    emp.AddressId = null;
                }
            }

            var addressesToRemove = context.Addresses
                .Where(a => a.Town.Name == "Seattle")
                .ToList();

            foreach (var address in addressesToRemove)
            {
                context.Addresses.Remove(address);
            }

            var townToRemove = context.Towns
                .FirstOrDefault(t => t.Name == "Seattle");

            context.Towns.Remove(townToRemove);

            context.SaveChanges();

            return $"{addressesToRemove.Count} addresses in Seattle were deleted";
        }

        //Problem 14
        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employeesProjectsToDelete = context.EmployeesProjects
                .Where(ep => ep.ProjectId == 2);

            var project = context.Projects
                .Where(p => p.ProjectId == 2)
                .Single();

            foreach (var ep in employeesProjectsToDelete)
            {
                context.EmployeesProjects.Remove(ep);
            }

            context.Projects.Remove(project);

            context.SaveChanges();

            context.Projects
                .Take(10)
                .Select(p => p.Name)
                .ToList()
                .ForEach(p => sb.AppendLine(p));

            return sb.ToString().Trim();
        }

    }
}
