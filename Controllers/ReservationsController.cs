using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class ReservationsController : Controller
{
    public IActionResult List() => View();

    public IActionResult Create() => View();


    public IActionResult Active() => View();

    public IActionResult Upcoming() => View();

    public IActionResult Details(int id) => View();


}