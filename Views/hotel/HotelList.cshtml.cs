using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HotelAndLogin.Views.hotel
{
    public class HotelListModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public HotelListModel(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IEnumerable<Hotel> Hotels { get; set; }

        public async Task OnGet()
        {
            Hotels = await _db.Hotel.ToListAsync();
           
        }
     
    }
}
