using Angular2.Models;
using Angular2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular2.Controllers
{
    public class PositionsController : Controller
    {
        private readonly IPositionsService _positionService;

        public PositionsController(IPositionsService positionService)
        {
            _positionService = positionService;
        }

        // GET: api/Positions
        [HttpGet]
        public async Task<IEnumerable<Positions>> Get()
        {
            return await _positionService.GetPositionsList();
        }
    }
}
