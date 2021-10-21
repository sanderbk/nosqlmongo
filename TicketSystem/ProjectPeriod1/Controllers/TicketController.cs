using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectPeriod1.Models;
using ProjectPeriod1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjectPeriod1.Controllers
{

    [Authorize]
    public class TicketController : Controller
    {
        private readonly TicketService _ticSvc;
        private readonly UserService _usrService;

        public TicketController(TicketService ticketService, UserService userService)
        {
            _ticSvc = ticketService;
            _usrService = userService;
        }

        [AllowAnonymous]
        public ActionResult<IList<Ticket>> List()
        {
            TempData["Tickets"] = _ticSvc.Read();
            return View(TempData["Tickets"]);
        }

        public ActionResult<IList<Ticket>> Index()
        {
            TempData["Tickets"] = _ticSvc.Read();
            return View(TempData["Tickets"]);
        }

        [HttpGet]
        public ActionResult Create()
        {

            IList<User> users = _usrService.Read();
            List<SelectListItem> getUser = new List<SelectListItem>();

            foreach (var usr in users as IList<User>)
            {
                getUser.Add(new SelectListItem { Text = usr.FirstName, Value = usr.MongoId });
            }

            ViewBag.getUsers = getUser;

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult<Ticket> Create(Ticket ticket)
        {
            ticket.Created = DateTime.Now;


            IList<User> users = _usrService.Read();
            List<SelectListItem> getUser = new List<SelectListItem>();

            foreach (var usr in users as IList<User>)
            {
                getUser.Add(new SelectListItem { Text = usr.FirstName, Value = usr.MongoId });

            }

            string id = Request.Form["getUsers"].ToString();

            User u1 = users.Where(usr => usr.MongoId == id).FirstOrDefault();
            ticket.Status = TicketStatus.Open;

            ticket.User = u1;


            ViewBag.getUsers = getUser;


            if (ModelState.IsValid)
            {
                _ticSvc.Create(ticket);
            }
            return View();
        }

        [HttpGet]
        public ActionResult<Ticket> Edit(string id)
        {

            IList<User> users = _usrService.Read();
            List<SelectListItem> getUser = new List<SelectListItem>();

            foreach (var usr in users as IList<User>)
            {
                getUser.Add(new SelectListItem { Text = usr.FirstName, Value = usr.MongoId });
            }

            ViewBag.getUsers = getUser;
            return View(_ticSvc.Find(id));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ticket ticket)
        {
            ticket.LastUpdated = DateTime.Now;


            IList<User> users = _usrService.Read();
            List<SelectListItem> getUser = new List<SelectListItem>();

            foreach (var usr in users as IList<User>)
            {
                getUser.Add(new SelectListItem { Text = usr.FirstName, Value = usr.MongoId });

            }

            string id = Request.Form["getUsers"].ToString();

            User u1 = users.Where(usr => usr.MongoId == id).FirstOrDefault();


            ticket.User = u1;


            ViewBag.getUsers = getUser;




            if (ModelState.IsValid)
            {

                _ticSvc.Update(ticket);
                return RedirectToAction("Index");
            }
            return View(ticket);
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            _ticSvc.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

