using WorkoutsAPI.Models;
using WorkoutsAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WorkoutsAPI.Controllers{


    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutsController : ControllerBase
    {
        private readonly WorkoutService _workoutService;

        public WorkoutsController(WorkoutService workoutService)
        {
            _workoutService = workoutService;
        }
    }
}