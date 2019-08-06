using AspNetCoreTodo.Models;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
        Task<bool> AddItemAsync(TodoItem newItem);
    }
}
