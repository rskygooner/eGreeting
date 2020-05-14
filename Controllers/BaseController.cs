using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGreeting.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eGreeting.Controllers
{
    public class BaseController : Controller
    {
        public bool IsAdmin()
        {
            var username = HttpContext.Session.GetString("username");
            var role = HttpContext.Session.GetString("role");
            if (username != null && role != null)
            {
                if (role == Role.Admin.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsLoggedIn()
        {
            var username = HttpContext.Session.GetString("username");
            if (username != null)
            {
                return true;
            }
            return false;
        }
    }
}