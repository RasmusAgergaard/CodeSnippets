using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Learn ASP.NET Core you fucker!",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new TodoItem
            {
                Title = "Build awesome stuff",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };

            //One way to do it
            //TodoItem[] items = { item1, item2 };
            //return Task.FromResult(items);

            //And the shoter smarter one
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
