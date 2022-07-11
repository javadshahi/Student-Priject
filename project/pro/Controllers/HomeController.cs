using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using model.Models;

namespace model.Controllers;

public class HomeController : Controller
{
    private readonly Istudent db;
    public HomeController(Istudent _db)
    {
        db = _db;
    }
   
    public IActionResult addstudent(Vm_student st)
    {
        db.Addstudent(st);
        // ViewBag.list = db.GetAllstudents();
        return RedirectToAction("index");
    }
    public IActionResult Index()
    { 
        ViewBag.list = db.GetAllstudents();
        return View();
    }
}
