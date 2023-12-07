using BootcampApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootcampApp.Controllers;
public class BootcampController : Controller
{
 
    public IActionResult List()
    {
        var kurslar = new List<Bootcamp>(){
            new Bootcamp(){
                Id = 1,Title="Full Stack Bootcamp",Image="1.jpg",Description="Html,css,javascript ve Asp.net dersleri"
            },
            new Bootcamp(){
                Id = 2,Title="Game Bootcamp",Image="2.jpg",Description="Unity ile mobil oyun geliştirme"
            },
             new Bootcamp(){
                Id = 3,Title="SQL Bootcamp",Image="3.jpg",Description="SQL Server kullanımı"
            },
             new Bootcamp(){
                Id = 4,Title="Backend Bootcamp",Image="4.jpg",Description="Arkaplanda Web Geliştirme"
            }
        };
        return View(kurslar);
    }
}