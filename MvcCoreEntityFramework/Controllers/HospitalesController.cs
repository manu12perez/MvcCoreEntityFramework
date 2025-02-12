using Microsoft.AspNetCore.Mvc;
using MvcCoreEntityFramework.Models;
using MvcCoreEntityFramework.Repositories;

namespace MvcCoreEntityFramework.Controllers
{
    public class HospitalesController : Controller
    {
        private RepositoryHospital repo;

        public HospitalesController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            return View(hospitales);
        }
    }
}
