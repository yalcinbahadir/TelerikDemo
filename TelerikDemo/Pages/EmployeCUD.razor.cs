using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik.Blazor.Components;
using TelerikDemo.Data;

namespace TelerikDemo.Pages
{
    public partial class EmployeCUD
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        protected override Task OnInitializedAsync()
        {
            Employees = DataProvider.GetEmployees();
            return base.OnInitializedAsync();
        }

        private void CreateEmployee(GridCommandEventArgs args)
        {
            Employee employee = (Employee)args.Item;
            DataProvider.Create(employee);
            Employees = DataProvider.GetEmployees();
        }

        private void UpdateEmployee(GridCommandEventArgs args)
        {
            Employee employee = (Employee)args.Item;
            DataProvider.Update(employee);
            Employees = DataProvider.GetEmployees();
        }
        private void DeleteEmployee(GridCommandEventArgs args)
        {
            Employee employee = (Employee)args.Item;
            DataProvider.Delete(employee);
            Employees = DataProvider.GetEmployees();
        }
    }
}
