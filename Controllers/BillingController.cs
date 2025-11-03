using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class BillingController : Controller
{
    public IActionResult Invoices() => View();

    public IActionResult Create() => View();

    public IActionResult Payments() => View();

    public IActionResult Statements() => View();

    public IActionResult Pricing() => View();

}