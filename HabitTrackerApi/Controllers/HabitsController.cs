using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTrackerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HabitsController : ControllerBase
    {
        private static readonly string[] Habits = new[]
        {
            "Code For An Hour", "Go To Bed By 10 PM", "Brush Teeth - AM", "Brush Teeth - PM", "Walk 2 Miles" 
        };

        private readonly ILogger<HabitsController> _logger;

        public HabitsController(ILogger<HabitsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string[] Get()
        {
            return Habits;
        }
    }
}
