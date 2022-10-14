using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestCkEditor.Models;

namespace TestCkEditor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //private DataContext Context { get;  }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //Context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SaveEmp(IFormCollection formValues)
        {
            Employee employee = new Employee();
            employee.EmpDescription = formValues["description"]; //get ckeditor value
            employee.EmpName = formValues["name"];
            //this.Context.Employee.Add(employee);
            //this.Context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}