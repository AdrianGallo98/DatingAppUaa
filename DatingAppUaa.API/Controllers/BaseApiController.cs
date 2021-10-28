﻿using DatingAppUaa.API.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DatingAppUaa.API.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
    }
}
