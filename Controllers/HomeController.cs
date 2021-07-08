using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Schedule_core_sample.Models;

namespace Schedule_core_sample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.datasource = GetScheduleData();
            return View();
        }
        public List<ScheduleData> GetScheduleData()
        {
            List<ScheduleData> scheduleData = new List<ScheduleData>();
            scheduleData.Add(new ScheduleData
            {
                Id = 1,
                Subject = "Testing",
                StartTime = new DateTime(2018, 4, 4, 11, 0, 0),
                EndTime = new DateTime(2018, 4, 4, 13, 0, 0)
            });
            return scheduleData;
        }

        public class ScheduleData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
        }
    }
}
