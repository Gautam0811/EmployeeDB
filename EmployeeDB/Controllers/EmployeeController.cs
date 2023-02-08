using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace EmployeeDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        List<EmployeeModel> employees;
        public EmployeeController()
        {
            employees = new List<EmployeeModel>(){
            new EmployeeModel(){id=1001, Name="David Klekamp", Offers=0, Quotes=3, Orders=314, Fullfilments=276, Pickups=10, AR=0},
            new EmployeeModel(){id=1002, Name="Hannah", Offers=10, Quotes=6, Orders=567, Fullfilments=762, Pickups=20, AR=3},
            };
        }
        [Route("")]
        public IActionResult allemployee()
        {
            var employee = employees;
            return Ok(employee);
        }

        [Route("{id}")]
        public IActionResult getEmployee(int id)
        {
            var employee = employees.Find(e => e.id == id);
            if (id == 0)
            {
                return BadRequest();
            }
            else if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }

}