using assessment_sinar_tambang.Data;
using assessment_sinar_tambang.Models.DataTables;
using assessment_sinar_tambang.Models.MatKul;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assessment_sinar_tambang.Controllers.matakuliahController
{
    public class MatkulController : Controller
    {
        private readonly MvcBuilder mvcBuilder;

        public MatkulController(MvcBuilder mvcBuilder)
        {
            this.mvcBuilder = mvcBuilder;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var matakuliah = await mvcBuilder.matakuliah.ToListAsync();
            return View(matakuliah);
        } 

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddMatkulModel addMatkulRequest)
        {
            var matakuliah = new Matakuliah()
            {
                Kode_MK = addMatkulRequest.Kode_MK,
                Nama_MK = addMatkulRequest.Nama_MK,
                SKS = addMatkulRequest.SKS
            };

            await mvcBuilder.matakuliah.AddAsync(matakuliah);
            await mvcBuilder.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
