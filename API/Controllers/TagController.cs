using Microsoft.AspNetCore.Mvc;

namespace API;

public class TagController : ControllerBase
{
    public IActionResult Index()
    {
        return View();
    }
}