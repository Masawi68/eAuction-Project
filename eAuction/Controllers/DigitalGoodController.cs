using eAuction.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eAuction.Controllers
{
	public class DigitalGoodController : Controller
	{
		private readonly AppDbContext _context;

		public DigitalGoodController(AppDbContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			var allDigitalGood = await _context.DigitalGood.ToListAsync();
			return View(allDigitalGood);
		}
	}
}
