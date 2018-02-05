using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public class DummyController: Controller
    {
        private CityInfoContext _db;

        public DummyController(CityInfoContext db)
        {
            _db = db;
        }

        [HttpGet("api/testdb")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }

    }
}
