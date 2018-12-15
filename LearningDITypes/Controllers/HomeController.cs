using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LearningDITypes.Models;
using LearningDITypes.Abstractions;
using LearningDITypes.Services;
using Unity;

namespace LearningDITypes.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDIConstructorInjection _diConstructorInjection;
    

        public HomeController(IDIConstructorInjection diConstructorInjection)
        {
            _diConstructorInjection = diConstructorInjection;

        }

        public IActionResult Index(DIMethodInjection diMethodInjection)
        {
            string constructorInjection = _diConstructorInjection.GetData();

            string methodInjection = diMethodInjection.GetData();

            string propertyInjection = GetProperty();

            return View();
        }

        private dynamic GetProperty()
        {
            var container = new UnityContainer();
            //Just declares the class type as a repository.
            container.RegisterType<IDIPropertyInjection, DIPropertyRepository>();

            var injectedProperty = container.Resolve<DIPropertyInjection>();

            return injectedProperty.GetType().ToString();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";


            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
