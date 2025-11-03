using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class ReportsController : Controller
{
    public IActionResult Sales() => View();
    public IActionResult Utilization() => View();

    public IActionResult Maintenance() => View();

    public IActionResult Inventory() => View();


    public IActionResult Customer() => View();

    public IActionResult Revenue() => View();

}