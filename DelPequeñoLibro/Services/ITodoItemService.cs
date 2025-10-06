using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DelPequeñoLibro.Models;

namespace DelPequeñoLibro.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemAsync();
    }
}
