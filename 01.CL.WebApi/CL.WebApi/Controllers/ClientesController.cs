using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CL.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value" };
        }

        [HttpGet]
        public IEnumerable<string> GetById(int id)
        {
            return new string[] { "value" };
        }
    }
}