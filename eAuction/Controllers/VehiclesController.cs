using eAuction.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eAuction.Controllers
{
	public class VehiclesController : Controller
	{
		private readonly AppDbContext _context;

		public VehiclesController(AppDbContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			var allVehicles = await _context.Vehicles.OrderBy(n => n.LotNumber).ToListAsync();
			return View(allVehicles);
		}
	}
}
