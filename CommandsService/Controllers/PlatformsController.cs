using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
      

        public PlatformsController()
        {
            
        }

        // [HttpGet]
        // public ActionResult<IEnumerable<PlatformreadDto>> GetPlatforms()
        // {
        //     Console.WriteLine("--> Getting Platforms from CommandsService");

        //     var platformItems = _repository.GetAllPlatforms();

        //     return Ok(_mapper.Map<IEnumerable<PlatformreadDto>>(platformItems));
        // }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound POST # Command Service");

            return Ok("Inbound test of from Platforms Controler");
        }
    }
}