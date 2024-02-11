using Microsoft.AspNetCore.Mvc;
using PiramidsManagementSystem.Models;

namespace PiramidsManagementSystem.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogList = new List<DogViewModel>();
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            {
                Name = "Sif",
                Age = 2
            };

            dogList.Add(doggo);

            return View(dogList);
        }
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogList.Add(dogViewModel);
            return RedirectToAction("Index");
        }
        public string Hello()
        {
            return "Who's there?";
        }
    }
}
