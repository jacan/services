using NServiceBus;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserService.Frontend.Models;
using UserService.Messages.Commands;

namespace UserService.Frontend.Controllers
{
	public class HomeController : Controller
	{
		protected readonly IBus _bus;
		protected readonly IContainer _container;

		public HomeController(IBus bus, IContainer container)
		{
			_bus = bus;
			_container = container;
		}

		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(NewBasicUser newBasicUser)
		{
			if (ModelState.IsValid)
			{
				var basicUser = newBasicUser;

				CreateUserCommand newUserCmd = new CreateUserCommand(DateTime.Now)
				{
					EmailAddress = newBasicUser.MailForVerification,
					UsernameDesired = newBasicUser.DesiredUsername,
				};

				_bus.Send(newUserCmd);

				return RedirectToAction("Index");
			}

			return View("Index", newBasicUser);
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