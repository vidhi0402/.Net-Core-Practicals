using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Practical_17.Models;
using Ptactical_17.ViewModel.Helper;
using Ptactical_17.ViewModel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Ptactical_17.ViewModel.Controllers
{
    public class HomeController : Controller
    {
        StudentAPI _api = new StudentAPI();

        public async Task<IActionResult> Index()
        {
            List<Student> Students = new List<Student>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Students");
            if (res.IsSuccessStatusCode)
            {
                var reslut = res.Content.ReadAsStringAsync().Result;
                Students = JsonConvert.DeserializeObject<List<Student>>(reslut);
            }
            return View(Students);
        }
        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Student Students = new Student();
            if (id == null)
            {
                return NotFound();
            }
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Students/" + id);
            if (res.IsSuccessStatusCode)
            {
                var reslut = res.Content.ReadAsStringAsync().Result;
                Students = JsonConvert.DeserializeObject<Student>(reslut);
            }
            return View(Students);
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student Students)
        {
            if (ModelState.IsValid)
            {

                HttpClient client = _api.Initial();

                var postdata = client.PostAsJsonAsync("api/Students", Students);
                postdata.Wait();
                var res = postdata.Result;
                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }

            }
            return View(Students);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            Student Students = new Student();
            if (id == null)
            {
                return NotFound();
            }

            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Students/" + id);
            if (res.IsSuccessStatusCode)
            {
                var reslut = res.Content.ReadAsStringAsync().Result;
                Students = JsonConvert.DeserializeObject<Student>(reslut);
            }
            return View(Students);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student Students)
        {
            if (id != Students.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    HttpClient client = _api.Initial();

                    var postdata = client.PutAsJsonAsync("api/Students/" + id, Students);
                    postdata.Wait();
                    var res = postdata.Result;
                    if (res.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (Exception e)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            return View(Students);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Student students = new Student();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync("api/Students/" + id);
            return RedirectToAction(nameof(Index));
        }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

      

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
