using Microsoft.AspNetCore.Mvc;
using RazorViews.Models;

namespace RazorViews.Controllers
{
	public class HomeController : Controller
	{
		[Route("/")]
		public IActionResult Index()
		{
			List<Person> person = new List<Person>()
			{
				new Person() { PersonName = "Saurab Rajbanshi", DateOfBirth = Convert.ToDateTime("2003-09-04"),PersonGender = Gender.Male },
				new Person(){ PersonName = "Gaurav Rajbanshi", DateOfBirth = Convert.ToDateTime("2006-09-04"),PersonGender = Gender.Male },
				new Person(){PersonName = "Arav Rajbanshi", DateOfBirth = Convert.ToDateTime("2008-09-04"),PersonGender = Gender.Male}
			};
			//viewdata
			//ViewData["person"] = person;

			//viewbag
			ViewBag.person = person;
			return View();
		}
	}
}
