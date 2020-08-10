using Microsoft.AspNetCore.Mvc;
using MyFrameworkList.Application;
using MyFrameworkList.Application.DTOs;
using System;

namespace MyFrameworkList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IApplicationServiceLanguage _applicationServiceLanguage;

        public LanguageController(IApplicationServiceLanguage applicationServiceLanguage) => _applicationServiceLanguage = applicationServiceLanguage;

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_applicationServiceLanguage.GetAll());
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
                return Ok(_applicationServiceLanguage.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] LanguageDTO language)
        {
            try
            {
                _applicationServiceLanguage.Add(language);

                return Ok("Language successfull created.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] LanguageDTO language)
        {
            try
            {
                _applicationServiceLanguage.Update(language);

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
                _applicationServiceLanguage.Remove(id);

                return Ok("Language successfull deleted.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
