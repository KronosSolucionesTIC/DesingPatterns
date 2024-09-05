using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using Tools.Generator;

namespace DesignPatternsASP.Controllers
{
    public class GeneratorFileController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private GeneratorConcretBuilder _generatorConcreteBuilder;

        public GeneratorFileController(IUnitOfWork unitOfWork, GeneratorConcretBuilder generatorConcretBuilder)
        {
            _unitOfWork = unitOfWork;
            _generatorConcreteBuilder = generatorConcretBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile)
        {
            try
            {
                var beers = _unitOfWork.Beers.Get();
                List<string> content = beers.Select(b => b.Name).ToList();
                string path = "file" + DateTime.Now.Ticks + new Random().Next(1000) + ".txt";
                var generatorDirector = new GeneratorDirector(_generatorConcreteBuilder);

                if (optionFile == 1)
                    generatorDirector.CreateSimpleJson(content, path);
                else
                    generatorDirector.CreateSimplePipe(content, path);

                var generate = _generatorConcreteBuilder.GetGenerator();
                generate.Save();
                
                return Json("Archivo generado");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
