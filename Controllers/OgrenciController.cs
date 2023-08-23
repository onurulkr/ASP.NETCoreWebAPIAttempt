using ASP.NETCoreWebAPIAttempt.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebAPIAttempt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OgrenciController : ControllerBase
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>
        {
            new Ogrenci{ Id = 1, AdSoyad = "Onur Ülker" },
            new Ogrenci{ Id = 2, AdSoyad = "Can Gezgin" },
            new Ogrenci{ Id = 2, AdSoyad = "Şafak Yaman" }
        };

        [HttpGet]
        public List<Ogrenci> Get()
        {
            return ogrenciler;
        }

        [HttpGet("id")]
        public Ogrenci Get(int id)
        {
            return ogrenciler.FirstOrDefault(o => o.Id == id);
        }

        [HttpPost]
        public Ogrenci Post(Ogrenci ogrenci)
        {
            ogrenciler.Add(ogrenci);

            return ogrenci;
        }
    }
}
