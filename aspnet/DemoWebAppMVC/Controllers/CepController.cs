using Microsoft.AspNetCore.Mvc;
using DemoWebAppMVC.Services;
using DemoWebAppMVC.Models;

namespace DemoWebAppMVC.Controllers;

public class CepController : Controller
{
    private readonly ICepRepository _cepRepository;

    public CepController(ICepRepository cepRepository)
    {
        _cepRepository = cepRepository;
    }

    //GET .../Cep/Index ou .../Cep
    public IActionResult Index()
    {
        var ceps = _cepRepository.ConsultarTodos();
        var cepsviewmodel = ceps.Select(c => CepModel.ParaViewModel(c));
        return View(cepsviewmodel);
    }
}