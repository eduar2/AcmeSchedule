using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSchedule.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public List<ScheduleWork> schedules { get; set; }

        public double payment { get; set; }
        public bool HasError { get; set; } = false;
    }
}
