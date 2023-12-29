﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TableResevationforRestaurant.Authorization;

namespace TableResevationforRestaurant.Controllers.Auth_controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]

    public class ProtectedController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetData()
        {
            var status = new Status();
            status.StatusCode = 1;
            status.Message = "Data from protected controller";
            return Ok(status);
        }
    }
}
