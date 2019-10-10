using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Web.Models;

namespace YumaPos.Tests.Load.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoadTestDbContext _db;
        public HomeController(IEntityContainer entityContainer)
        {
            _db = entityContainer.Context;
        }
        public ActionResult Index()
        {
            var model = new HomeModel()
            {
                ServersCount = _db.Servers.Count(),
                TenantsCount = _db.Tenants.Count(),
                JobsCount = _db.Jobs.Count(),
                StoresCount = _db.Stores.Count(),
                TestTasksCount = _db.TestTasks.Count(),
                ClientsCount = _db.Clients.Count(),
                EmployeesCount = _db.Employees.Count(),
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}