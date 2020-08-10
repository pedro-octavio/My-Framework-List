using System;
using Microsoft.AspNetCore.Mvc;
using MyFrameworkList.Application.Interfaces;

namespace MyFrameworkList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrameworkLanguageController : ControllerBase
    {
        private readonly IApplicationServiceFrameworkLanguage _applicationServiceFrameworkLanguage;

        public FrameworkLanguageController(IApplicationServiceFrameworkLanguage applicationServiceFrameworkLanguage) => _applicationServiceFrameworkLanguage = applicationServiceFrameworkLanguage;

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_applicationServiceFrameworkLanguage.GetAll());
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
                return Ok(_applicationServiceFrameworkLanguage.GetByFrameworkId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
