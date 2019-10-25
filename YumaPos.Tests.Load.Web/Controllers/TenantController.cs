using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Data.Helpers;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Web.Interfaces;
using YumaPos.Tests.Load.Web.Models;

namespace YumaPos.Tests.Load.Web.Controllers
{
    public class TenantController : Controller
    {
        private readonly ITenantService _tenantService;
        private readonly LoadTestDbContext _db;
        public TenantController(IEntityContainer entityContainer, ITenantService tenantService)
        {
            _tenantService = tenantService;
            _db = entityContainer.Context;
        }
        public ActionResult Index(string name)
        {
            var model = _db.Tenants;
            return View(model);
        }

        public ActionResult Edit(Guid id)
        {
            var tenant = _db.Tenants.Single(p => p.TenantId == id);
            return View(tenant);
        }

        [HttpPost]
        public ActionResult Save(Tenant model)
        {
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Import(Guid id)
        {
            await _tenantService.Import(id);
            return RedirectToAction("Edit", new {id});
        }
    }
}