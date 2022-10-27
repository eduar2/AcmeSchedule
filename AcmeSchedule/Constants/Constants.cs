using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSchedule.Constants

{
    static class Constants
    {
        //rates
        public const int regularWeekDayRate = 15;
        public const int extraWeekDayRate = 20;
        
        public const int nightWeekDayRate = 25;
        public const int regularWeekend = 20;
        
        public const int extraWeekend = 25;
        public const int nightWeekend = 30;

        //schedules
        public const int startRegular = 9;
        public const int endRegular = 18;
        
        public const int startExtra = 18;
        public const int endExtra = 24;
        
        public const int startNight = 0;
        public const int endNight = 9;

    }
}
