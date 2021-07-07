using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Final_DIARS.Models;

namespace Final_DIARS.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly AppPruebaContext context;
        public BaseController(AppPruebaContext context)
        {
            this.context = context;
        }
        protected User LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = context.Users.Where(o => o.Username == claim.Value).FirstOrDefault();
            return user;
        }
    }
}
