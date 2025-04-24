using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp03.Models;

namespace tp03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        if(Catalogo.dicDiscos==null){
            Catalogo.inicializarCatalogo();
        }
        
        ViewBag.dicDiscos=Catalogo.dicDiscos;
        return View();
    }

    public IActionResult MostrarDisco(int idDisco){

        if(Catalogo.dicDiscos.ContainsKey(idDisco)){
           ViewBag.disco=Catalogo.dicDiscos[idDisco]; 
           ViewBag.idDisco=idDisco;
        }else{
            ViewBag.idDisco=-1;
        }
        
        return View();
    }


}
