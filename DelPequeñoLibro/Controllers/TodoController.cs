using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DelPequeñoLibro.Services;
using DelPequeñoLibro.Models;

namespace DelPequeñoLibro.Controllers
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
            var items = await _todoItemService.GetIncompleteItemAsync();

            var model = new TodoViewModel()
            {
                Items = items
            };

            return View(model);
        }
    }
}
