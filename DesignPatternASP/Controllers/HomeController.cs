﻿using DesignPatterns.RepositoryPattern;
using DesignPatternASP.Configuration;
using DesignPatternASP.Models;
using DesignPatterns.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using Tools;

namespace DesignPatternsASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> _config;

        private readonly IRepository<Beer> _repository;
        public HomeController(IOptions<MyConfig> config,
            IRepository<Beer> repository)
        {
            _config = config;
            _repository = repository;
        }

        public IActionResult Index()
        {
            Log.GetInstance(_config.Value.PathLog).Save("Entro a Index");
            IEnumerable<Beer> list = _repository.Get();
            return View("Index", list);
        }

        public IActionResult Privacy()
        {
            Log.GetInstance(_config.Value.PathLog).Save("Entro a Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}