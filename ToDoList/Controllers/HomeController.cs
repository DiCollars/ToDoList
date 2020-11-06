using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Services.Interfaces;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        public IApplicationService _service;

        public HomeController(ApplicationContext context, IApplicationService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            ViewBag.Theme = _service.GetMainTheme();
            _service.DateCheck();

            return View();
        }

        public IActionResult MonthStatistic(int? id, int? subPriority)
        {
            ViewBag.Theme = _service.GetMainTheme();
            var ViewData = _service.GetViewLists(id, null);
            ViewData.ListTasks = _service.GetTasks(id, subPriority).ListTasks;
            ViewBag.Day = id;

            return View(ViewData);
        }

        public IActionResult Add(TaskOf taskOf)
        {
            ViewBag.Theme = _service.GetMainTheme();
            _service.AddData(taskOf);

            return View();
        }

        public IActionResult Settings(int? id)
        {
            ViewBag.Theme = _service.GetMainTheme();
            _service.SwitchTheme(id);

            return View();
        }

        public IActionResult Today(int? id, Priority? subPriority)
        {
            ViewBag.Theme = _service.GetMainTheme();
            ViewBag.Now = $"{DateGenerator.allMonths.First(m => m.Key == DateTime.Now.Month).Value} {DateTime.Now.Day}";
            var viewModel = _service.SwitchData(id, subPriority);

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
