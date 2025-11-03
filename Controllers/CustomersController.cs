using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class CustomersController : Controller
{
    public IActionResult Create() => View();

    public IActionResult Index() => View();

    public IActionResult Loyalty() => View();

}