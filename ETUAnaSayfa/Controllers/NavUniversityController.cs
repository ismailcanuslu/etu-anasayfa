using Microsoft.AspNetCore.Mvc;

namespace ETUAnaSayfa.Controllers;

public class NavUniversityController : Controller
{
    /*
     * ÜNİVERSİTEMİZ -> REKTÖRLÜK
     */
    public IActionResult RectorateMessage()
    {
        return View();
    }

    /*
     * ÜNİVERSİTEMİZ -> YÖNETİM
     */
    public IActionResult Management()
    {
        return View();
    }

    public IActionResult GeneralSecretariat()
    {
        return View();
    }
    
    /*
     * ÜNİVERSİTEMİZ -> KURUMSAL
     */

    public IActionResult CorporateIdentity()
    {
        return View();
    }
    
    public IActionResult VisionAndMission()
    {
        return View();
    }
    
    public IActionResult Kvkk()
    {
        return View();
    }
    
    public IActionResult StrategicPlan()
    {
        return View();
    }
    
    public IActionResult History()
    {
        return View();
    }
    
    public IActionResult LocationAndCampus()
    {
        return View();
    }
    
    public IActionResult UniversityLogo()
    {
        return View();
    }

}