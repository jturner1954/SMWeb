using Microsoft.AspNetCore.Mvc;
using ShelburneMemorialWeb.Models;
using System.Diagnostics;


namespace ShelburneMemorialWeb.Controllers
{

    public class ConfirmationController : Controller
    {
        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\SMNewWeb\ShelburneMemorialWeb\Data\masterprice.mdb;";
        public IActionResult Create()
        {
            return View();
        }
    }
}
