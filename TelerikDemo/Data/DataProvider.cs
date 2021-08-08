using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikDemo.Data
{
    public static class DataProvider
    {
        private static List<Department> _departments = new()
        {
            new Department { Id=  1, Name="IT", Location="Genk"},
            new Department { Id = 2, Name = "HR", Location = "Tongeren" },
            new Department { Id = 3, Name = "Production", Location = "Hasselt" }
        };

        private static List<Employee> _employees = new() {
            //dept-1
            new Employee { Id=1, FirstName="John&", LastName="Winter", DateOfBirth=new DateTime(2003,01,02), Description="Description of John", Email="John@test.com", Gender=Gender.Male, IsMarried=false, DepartmentId=1 },
            new Employee { Id = 2, FirstName = "Sam", LastName = "Winter", DateOfBirth = new DateTime(2004,01,01), Description = "Description of Sam", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 1 },
            new Employee { Id = 3, FirstName = "Ceyn", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 1 },
            new Employee { Id = 4, FirstName = "Donald", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 1 },

            //dept-2
            new Employee { Id = 5, FirstName = "Tom", LastName = "Zomer", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Tom", Email = "John@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            new Employee { Id = 6, FirstName = "Hans", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Hans", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            new Employee { Id = 7, FirstName = "Mark", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 2 },
            new Employee { Id = 8, FirstName = "Roni", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            //dept-3
            new Employee { Id = 9, FirstName = "Arya", LastName = "Zomer", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Tom", Email = "John@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
            new Employee { Id = 10, FirstName = "Natalie", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Hans", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
            new Employee { Id = 11, FirstName = "Patricia", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 3 },
            new Employee { Id = 12, FirstName = "Silvia", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
            //dept-1
            new Employee { Id = 14, FirstName = "John&", LastName = "Winter", DateOfBirth = new DateTime(2003, 01, 02), Description = "Description of John", Email = "John@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 1 },
            new Employee { Id = 15, FirstName = "Sam", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Sam", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 1 },
            new Employee { Id = 16, FirstName = "Ceyn", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 1 },
            new Employee { Id = 17, FirstName = "Donald", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 1 },

            //dept-2
            new Employee { Id = 18, FirstName = "Tom", LastName = "Zomer", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Tom", Email = "John@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            new Employee { Id = 19, FirstName = "Hans", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Hans", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            new Employee { Id = 20, FirstName = "Mark", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 2 },
            new Employee { Id = 21, FirstName = "Roni", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            //dept-3
            new Employee { Id = 22, FirstName = "Arya", LastName = "Zomer", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Tom", Email = "John@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
            new Employee { Id = 23, FirstName = "Natalie", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Hans", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
            new Employee { Id = 24, FirstName = "Patricia", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 3 },
            new Employee { Id = 25, FirstName = "Silvia", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
        };

        public static void Delete(Employee employee)
        {
            _employees.Remove(employee);
        }

        public static void Update(Employee model)
        {
            var existing = GetEmployeeById(model.Id);
            if (existing is not null)
            {
                existing.FirstName = model.FirstName;
                existing.LastName = model.LastName;
                existing.Email = model.Email;
                existing.DateOfBirth = model.DateOfBirth;
                existing.DepartmentId = model.DepartmentId;
                existing.Salary = model.Salary;
                existing.Gender = model.Gender;
                existing.IsMarried = model.IsMarried;
                existing.Description = model.Description;

            }
           
        }

        public static List<Employee>  GetEmployees()
        {
            var result = _employees.Join(_departments, 
                                         employee=>employee.DepartmentId, 
                                         department=>department.Id,
                                         (employee,department)=>new Employee 
                                         {
                                             Id=employee.Id, 
                                             FirstName=employee.FirstName, 
                                             LastName=employee.LastName, 
                                             DateOfBirth=employee.DateOfBirth, 
                                             Email=employee.Email, 
                                             Description=employee.Description, 
                                             DepartmentId=employee.DepartmentId, 
                                             Gender=employee.Gender, 
                                             ImageUrl=employee.ImageUrl, 
                                             IsMarried=employee.IsMarried, 
                                             Salary=employee.Salary, 
                                             Department=new Department 
                                                         { 
                                                             Id=department.Id, 
                                                             Location=department.Location, 
                                                             Name=department.Name
                                                         }
                                         });
            return result.ToList();
        }

        public static void Create(Employee employee)
        {
            _employees.Add(employee);
        }

        private static Employee GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(e=>e.Id==id);
        }
    }
}
