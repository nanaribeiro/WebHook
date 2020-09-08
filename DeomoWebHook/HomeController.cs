using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DeomoWebHook
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [GitHubWebHook]
        public IActionResult GitHubHandler(JObject data)
        {
            var result = JsonConvert.SerializeObject(data);
            return Ok();
        }
    }
}
