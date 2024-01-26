using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class ItemController : ControllerBase
    {
        private static List<Automat> automats = new List<Automat>
        {
            new Automat { id_automat = 1,id_adress = 3,
            id_cell = 5, operable = true },
            new Automat { id_automat = 2,id_adress = 2,
            id_cell = 2, operable = false },
            new Automat { id_automat = 3,id_adress = 5,
            id_cell = 3, operable = true },

        };

        private static List<Employee> employees = new List<Employee>{
            new Employee {Id = 1, Name = "Иван", Surname = "Иванов"},
            new Employee {Id = 2, Name = "Виктор", Surname = "Иванов"},
            new Employee {Id = 2, Name = "Степан", Surname = "Аркадьев"},
        };

        [HttpGet("get/vending-machines")]
        public IActionResult GetAutomats()
        {
            return Ok(automats);
        }

        [HttpGet("get/employees")]
        public IActionResult GetEmployee()
        {
            return Ok(employees);
        }

        [HttpGet("get/employee/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            Console.WriteLine(id);
            var item = employees.Find(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(new { item.Name, item.Surname });
        }

        [HttpPost("add/employee")]
        public IActionResult AddEmployee([FromBody] Employee newItem)
        {
            if (newItem == null)
            {
                return BadRequest("Invalid data");
            }

            newItem.Id = employees.Count + 1;
            employees.Add(newItem);

            return CreatedAtAction(nameof(GetEmployeeById), new { Id = newItem.Id }, newItem);
        }

        [HttpGet("get/vending/{machine_id}/status")]
        public IActionResult GetAutomatById(int machine_id)
        {
            Console.WriteLine(machine_id);
            var item = automats.Find(i => i.id_automat == machine_id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(new { id_automat = item.id_automat, operable = item.operable });
        }

        [HttpGet("get/EmployeByName/{name}")]
        public IActionResult GetEmployeByName(string name)
        {
            var matchingItems = employees.Where(i => i.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (matchingItems.Count == 0)
            {
                return NotFound();
            }

            return Ok(matchingItems);
        }

        [HttpPost("add")]
        public IActionResult CreateAutomat([FromBody] Automat newItem)
        {
            Console.WriteLine(newItem);
            if (newItem == null)
            {
                return BadRequest("Invalid data");
            }

            newItem.id_automat = automats.Count + 1;
            automats.Add(newItem);

            return CreatedAtAction(nameof(GetAutomatById), new { machine_id = newItem.id_automat }, newItem);
        }
    }

    public class Automat
    {
        public int id_automat { get; set; }
        public int id_adress { get; set; }
        public int id_cell { get; set; }
        public bool operable { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
