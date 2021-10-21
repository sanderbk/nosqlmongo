using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectPeriod1.Models;
using ProjectPeriod1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPeriod1.Controllers
{
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;
        private readonly UserService _usrSvc;
        private readonly TicketService _ticSvc;
        public UserController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, UserService userService, TicketService ticketService)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
            _usrSvc = userService;
            _ticSvc = ticketService;

        }

        [AllowAnonymous]
        public ActionResult<IList<User>> Index()
        {
            TempData["Users"] = _usrSvc.Read();
            ViewBag.TickCount = TicketCount();
            return View(TempData["Users"]);
        }
        
        public IList<Ticket> TicketCount()
        {
            return _ticSvc.Read();
        }
        public IActionResult CreateRole()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {

                ApplicationUser appUser = new ApplicationUser
                {

                    Id = user._id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email

                };

                IdentityResult result = await _userManager.CreateAsync(appUser, user.Password);


                if (result.Succeeded)
                {
                    ViewBag.Message = "Gebruiker gecreeerd";
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

            }
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(UserRole userRole)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await _roleManager.CreateAsync(new ApplicationRole() { RoleName = userRole.RoleName });
                if (result.Succeeded)
                {
                    ViewBag.Message = "Rol gecreeerd";
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(userRole);
        }
    }
}
