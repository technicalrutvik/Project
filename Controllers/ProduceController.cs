using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Data.Services;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProduceController : Controller
    {
        private readonly IProduceService _service;

        public ProduceController(IProduceService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //Get: producers details/1

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails==null)
            {
                return View("NotFound");
            } 

            return View(producerDetails);
        }

        //GET: Producers/create

        public IActionResult Create() {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create([Bind("fullName, picURL, Bio")]Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);
            

            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //GET: Producers/edit

        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if(producerDetails==null) return View("NotFound"); 
         
            return View(producerDetails);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id,[Bind("Id, picURL, fullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            if(id == producer.Id)
            {
                await _service.UpdateAsync(id,producer);
                return RedirectToAction(nameof(Index));

            }
            return View(producer);
        }


        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");

            return View(producerDetails);

        }

        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id, [Bind("Id")] Producer producer)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
