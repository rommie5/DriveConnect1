using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;

namespace AspnetCoreMvcFull.Controllers;

public class AuthController : Controller
{
  public IActionResult ForgotPassword() => View();
  public IActionResult Login() => View();
  public IActionResult Register() => View();
}
