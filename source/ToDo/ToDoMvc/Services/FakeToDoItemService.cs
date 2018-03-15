using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoMvc.Models;

namespace ToDoMvc.Services
{
    public class FakeToDoItemService : IToDoItemService
    {
        public Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync()
        {
            IEnumerable<ToDoItem> Items = new[]
            {
                new ToDoItem
                {
                    Title = "Learn ASP.NET Core",
                    DueAt = DateTimeOffSet.Now.AddDays(1)
                },
                new ToDoItem
                {
                    Title = "Build Awesome apps",
                    DueAt = DateTimeOffSet.Now.AddDays(2)
                }

            };

            return Task.FromResult(Items);
        }
    }
}