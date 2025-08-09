using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Data;
using ExpenseTracker.Models;

namespace ExpenseTracker.Pages.Expenses
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Expense> Expenses { get; set; } = new List<Expense>();

        public async Task OnGetAsync()
        {
            Expenses = await _context.Expenses
            .OrderByDescending(e => e.Date)
            .ToListAsync();
        }
    }
}