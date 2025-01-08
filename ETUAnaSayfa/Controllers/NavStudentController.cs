using Microsoft.AspNetCore.Mvc;

namespace ETUAnaSayfa.Controllers;

public class NavStudentController : Controller
{
    public IActionResult AcademicCalendar()
    {
        return View();
    }
}