using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ArraySort;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayController : ControllerBase
    {
        IArray _MyArray;
        private ArrayController(IArray service)
        {
            _MyArray = service;
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetArrayPosition()
        {
            try
            {
                var employees = _MyArray.GetArrayPosition();
                if (employees == null) return NotFound();
                return Ok(employees);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetSortedArray()
        {
            try
            {
                var employees = _MyArray.GetSortedArray();
                if (employees == null) return NotFound();
                return Ok(employees);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult SaveArray(SortedArray sortedarray)
        {
            try
            {
                var model = _MyArray.SaveArray(sortedarray);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
