using Microsoft.AspNetCore.Mvc;

namespace rabobankKasboekApp.login;

public class LoginController : Controller
{
    [Route("api")]
    [Route("api/login")]
    public IActionResult Login()
    {
        return Json(new { message = "Login" });
    }
}
