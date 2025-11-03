using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class CarsController : Controller
{
  public IActionResult Create() => View();
  
  public IActionResult Vehicles() => View();
  public IActionResult Categories() => View();
  
  public IActionResult Maintenance() => View();
 
  [HttpPost]
  public async Task<IActionResult> Create(AddVehicleViewModel model)
  {
    if (ModelState.IsValid)
    {
      return RedirectToAction("Index");
    }

    return View(model);
  }
}

public class AddVehicleViewModel
{
}
