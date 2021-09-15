using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectPeriod1.Models;
using ProjectPeriod1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjectPeriod1.Controllers
{

   // [Authorize]
    public class TicketController : Controller
    {
        private readonly TicketService _ticSvc;

        public TicketController(TicketService ticketService)
        {
            _ticSvc = ticketService;
        }

        [AllowAnonymous]
        public ActionResult<IList<Ticket>> Index() => View(_ticSvc.Read());

        [HttpGet]
        public ActionResult Create() => View();

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult<Ticket> Create(Ticket ticket)
        {
            ticket.Created = DateTime.Now;
           
          
            if (ModelState.IsValid)
            {
                _ticSvc.Create(ticket);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult<Ticket> Edit(string id) =>
            View(_ticSvc.Find(id));

        [HttpPost]
      //  [ValidateAntiForgeryToken]
        public ActionResult Edit(Ticket ticket)
        {
            ticket.LastUpdated = DateTime.Now;
            ticket.Created = ticket.Created.ToLocalTime();
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

