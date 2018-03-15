using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoMvc.Services;


namespace ToDoMvc.Controller
{
    public class ToDoController : Controller
    {
            private readonly IToDoItemService _toDoItemsService;

            public ToDoController(IToDoItemService toDoItemsService)
            {
                _toDoItemsService = toDoItemsService;
            }

            public async Task<IActionResult> Index()
            {
               //Get todo Items
               var todoItems = await _toDoItemsService.GetIncompleteItemsAsync();
               //Put into models
               var viewModel = new ToDoViewModel
               {
                   Items = todoItems
               };
               //Pass the view to model
               return View(viewModel);
            }
    }
}