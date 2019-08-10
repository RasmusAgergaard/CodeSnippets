using AspNetCoreTodo.Data;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AspNetCoreTodo.UnitTests
{
    public class TodoItemServiceShould
    {
        [Fact]
        public async Task AddNewItemAsIncompleteWithDueDate()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "Test_AddNewItem").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var service = new TodoItemService(context);

                var fakeUser = new IdentityUser
                {
                    Id = "fake-000",
                    UserName = "fake@example.com"
                };

                await service.AddItemAsync(new TodoItem
                {
                    Title = "Testing?"
                }, fakeUser);
            };

            using (var context = new ApplicationDbContext(options))
            {
                var itemsInDatabase = await context.Item.CountAsync();
                Assert.Equal(1, itemsInDatabase);

                var item = await context.Item.FirstAsync();
                Assert.Equal("Testing?", item.Title);
                Assert.False(item.IsDone);

                item.DueAt = DateTimeOffset.Now.AddDays(3);
                var difference = DateTimeOffset.Now.AddDays(3) - item.DueAt;
                Assert.True(difference < TimeSpan.FromSeconds(1));
            }
        }

        [Fact]
        public void ReturnsFalseIfPassedIdDosentExist()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TestDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var service = new TodoItemService(context);
                var fakeUser = new IdentityUser { Id = "fake-000", UserName = "fake@example.com" };
                var faceGuid = new Guid();

                var result = service.MarkDoneAsync(faceGuid, fakeUser).Result;

                Assert.False(result);
            }
        }

        [Fact]
        public async Task ReturnsTrueIfValidItemIsMarkedAsComplete()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TestDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var service = new TodoItemService(context);
                var fakeUser = new IdentityUser { Id = "fake-000", UserName = "fake@example.com" };
                await service.AddItemAsync(new TodoItem { Title = "Testing?" }, fakeUser);
                var item = await context.Item.FirstOrDefaultAsync();

                var result = service.MarkDoneAsync(item.Id, fakeUser).Result;

                Assert.True(result);
            }
        }

        [Fact]
        public async Task OnlyReturnItemsOwnedByAParticularUser()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TestDb").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var service = new TodoItemService(context);
                var fakeUser1 = new IdentityUser { Id = "fake-001", UserName = "fake1@example.com" };
                var fakeUser2 = new IdentityUser { Id = "fake-002", UserName = "fake2@example.com" };

                await service.AddItemAsync(new TodoItem { Title = "Testing?" }, fakeUser1);
                await service.AddItemAsync(new TodoItem { Title = "Testing?" }, fakeUser2);

                var items = service.GetIncompleteItemsAsync(fakeUser1).Result;

                Assert.Single(items);
            }
        }
    }
}
