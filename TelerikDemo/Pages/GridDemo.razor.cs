using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikDemo.Data;

namespace TelerikDemo.Pages
{
    public partial class GridDemo
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        protected override Task OnParametersSetAsync()
        {
            Employees = DataProvider.GetEmployees();
            return base.OnParametersSetAsync();
        }
    }
}
