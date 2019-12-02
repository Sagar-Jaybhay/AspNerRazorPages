using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tutorial.Model;

namespace asprazorpage.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepo _employeeRepo;

        public IEnumerable<ClsEmployee> _employeeList;

        public IndexModel(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public void OnGet()
        {
            _employeeList = _employeeRepo.GetAllEmployees();
        }
    }
}