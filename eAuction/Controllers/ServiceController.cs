using eAuction.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eAuction.Controllers
{
	public class ServiceController : Controller
	{
		private readonly AppDbContext _context;

		public ServiceController(AppDbContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			var allProduct = await _context.Service.ToListAsync();
			return View();
		}
	}
}
