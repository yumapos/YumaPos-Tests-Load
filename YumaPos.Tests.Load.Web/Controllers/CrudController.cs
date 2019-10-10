using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.Helpers;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Web.Models;

namespace YumaPos.Tests.Load.Web.Controllers
{
    public class CrudController : Controller
    {
        private readonly LoadTestDbContext _db;
        public CrudController(IEntityContainer entityContainer)
        {
            _db = entityContainer.Context;
        }
        public ActionResult Index(string name)
        {
            DataTable model = null;
            switch (name.ToLowerInvariant())
            {
                case "servers":
                    ViewBag.Title = "Servers";
                    model = _db.Servers.CopyGenericToDataTable();
                    break;
                case "tenants":
                    ViewBag.Title = "Tenants";
                    model = _db.Tenants.CopyGenericToDataTable();
                    break;
                case "stores":
                    ViewBag.Title = "Stores";
                    model = _db.Stores.CopyGenericToDataTable();
                    break;
                case "employees":
                    ViewBag.Title = "Employees";
                    model = _db.Employees.CopyGenericToDataTable();
                    break;
                case "testtasks":
                    ViewBag.Title = "TestTasks";
                    model = _db.TestTasks.CopyGenericToDataTable();
                    break;
                case "jobs":
                    ViewBag.Title = "Jobs";
                    model = _db.Jobs.CopyGenericToDataTable();
                    break;
                case "clients":
                    ViewBag.Title = "Clients";
                    model = _db.Clients.CopyGenericToDataTable();
                    break;
            }
            return View(model);
        }

        public ActionResult Edit()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult Save(dynamic model)
        {
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("Index");
        }
    }
}