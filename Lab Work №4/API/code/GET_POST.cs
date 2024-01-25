using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api/items")]
    public class ItemController : ControllerBase
    {
        private static List<Item> items = new List<Item>
        {
            new Item { Id = 1, Name = "Сотрудник 1" },
            new Item { Id = 2, Name = "Сотрудник 2" },
            new Item { Id = 3, Name = "Сотрудник 3" }
        };

        [HttpGet("get")]
        public IActionResult GetItems()
        {
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetItemById(int id)
        {
            var item = items.Find(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPost("add")]
        public IActionResult CreateItem([FromBody] Item newItem)
        {
            if (newItem == null)
            {
                return BadRequest("Invalid data");
            }

            newItem.Id = items.Count + 1;
            items.Add(newItem);

            return CreatedAtAction(nameof(GetItemById), new { id = newItem.Id }, newItem);
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
