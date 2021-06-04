using HotelAndLogin.Views.hotel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAndLogin.Controllers
{
    public class hotelController : Controller
    {
        private readonly ApplicationDbContext _db;

        public hotelController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Hotel.ToListAsync() });
        }
        public IActionResult HotelList()
        {
            return View();
        }
    }
}
