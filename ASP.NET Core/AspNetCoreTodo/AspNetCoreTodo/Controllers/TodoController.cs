using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _todoItemService.GetIncompleteItemsAsync();

            var model = new TodoViewModel()
            {
                Items = items
            };

            return View(model);
        }

        //The [ValidateAntiForgeryToken] attribute before the action tells ASP.NET Core that it should look for (and verify) the hidden verification token that was added to the form by the asp-action tag helper. This is an important security measure to prevent cross-site request forgery (CSRF) attacks, where your users could be tricked into submitting data from a malicious site. The verification token ensures that your application is actually the one that rendered and submitted the form.
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddItem(TodoItem newItem)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var successful = await _todoItemService.AddItemAsync(newItem);
            if (!successful)
            {
                return BadRequest("Could not add item");
            }

            return RedirectToAction("Index");
        }
    }
}