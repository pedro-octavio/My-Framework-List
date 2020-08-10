using System;
using Microsoft.AspNetCore.Mvc;
using MyFrameworkList.Application.DTOs;
using MyFrameworkList.Application.Interfaces;

namespace MyFrameworkList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrameworkController : ControllerBase
    {
        private readonly IApplicationServiceFramework _applicationServiceFramework;

        public FrameworkController(IApplicationServiceFramework applicationServiceFramework) => _applicationServiceFramework = applicationServiceFramework;

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_applicationServiceFramework.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            try
            {
                return Ok(_applicationServiceFramework.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] FrameworkDTO framework)
        {
            try
            {
                _applicationServiceFramework.Add(framework);

                return Ok("Language successfull created.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] FrameworkDTO framework)
        {
            try
            {
                _applicationServiceFramework.Update(framework);

                return Ok("Language successfull updated.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                _applicationServiceFramework.Remove(id);

                return Ok("Language successfull deleted.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
