using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UnitTest.Models;
using UnitTest.Service;
namespace UnitTest.Controllers;

public class HomeController : Controller
{
    private  ILogger<HomeController> _logger;
    private readonly IPerson _iPerson;
    public HomeController(ILogger<HomeController> logger, IPerson iPerson)
    {
        _logger = logger;
        _iPerson = iPerson;
    }

    public IActionResult Index()
    {
        return View(_iPerson.GetAll());
    }




    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Create(){
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Person per)
    {
        _iPerson.Create(per);
        return RedirectToAction("Index");
    }
   [HttpGet]
    public IActionResult Update(int id){
        _iPerson.GetPersonByID(id);
        return View();
    }
    [HttpPost]
    public IActionResult Update(Person per){
        _iPerson.Update(per);
        return RedirectToAction("Index");
    }
    
    public IActionResult Delete(){
        return View();
    }
    [HttpGet]
    public IActionResult Delete(int id){
         _iPerson.Delete(id);
        return RedirectToAction("Index");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
