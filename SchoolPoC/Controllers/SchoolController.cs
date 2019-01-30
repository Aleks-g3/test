using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using SchoolPoC.DAL.Entities;

namespace SchoolPoC.Controllers
{
    public class SchoolController : Controller
    {
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53529/api/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            IEnumerable<Teacher> teachList;
            HttpResponseMessage response = client.GetAsync("Teachers").Result;
            teachList = response.Content.ReadAsAsync<IEnumerable<Teacher>>().Result;
            return View(teachList);
        }
    }
}