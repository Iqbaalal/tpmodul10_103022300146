using Microsoft.AspNetCore.Mvc;
using tpmodul10_1302000001.Models;

namespace tpmodul10_1302000001.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Muhammad Iqbal", Nim = "103022300146" },
            new Mahasiswa { Nama = "Stephen Curry", Nim = "1302000002" },
            new Mahasiswa { Nama = "LeBron James", Nim = "1302000003" }
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswas;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswas[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswas.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswas.RemoveAt(id);
        }
    }
}