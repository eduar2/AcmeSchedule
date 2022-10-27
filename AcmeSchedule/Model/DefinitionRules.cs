using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSchedule.Model
{
    public class DefinitionRules
    {
        public List<ScheduleRule> schedules = new List<ScheduleRule>();

        public DefinitionRules()
        {

            this.schedules.Add(new ScheduleRule() { Day = Days.MO.ToString(), StartHour = Constants.Constants.startRegular, EndHour = Constants.Constants.endRegular, Cost = Constants.Constants.regularWeekDayRate });
            this.schedules.Add(new ScheduleRule() { Day = Days.MO.ToString(), StartHour = Constants.Constants.startExtra, EndHour = Constants.Constants.endExtra, Cost = Constants.Constants.extraWeekDayRate });
            this.schedules.Add(new ScheduleRule() { Day = Days.MO.ToString(), StartHour = Constants.Constants.startNight, EndHour = Constants.Constants.endNight, Cost = Constants.Constants.nightWeekDayRate });

            this.schedules.Add(new ScheduleRule() { Day = Days.TU.ToString(), StartHour = Constants.Constants.startRegular, EndHour = Constants.Constants.endRegular, Cost = Constants.Constants.regularWeekDayRate });
            this.schedules.Add(new ScheduleRule() { Day = Days.TU.ToString(), StartHour = Constants.Constants.startExtra, EndHour = Constants.Constants.endExtra, Cost = Constants.Constants.extraWeekDayRate });
            this.schedules.Add(new ScheduleRule() { Day = Days.TU.ToString(), StartHour = Constants.Constants.startNight, EndHour = Constants.Constants.endNight, Cost = Constants.Constants.nightWeekDayRate });

            this.schedules.Add(new ScheduleRule() { Day = Days.WE.ToString(), StartHour = Constants.Constants.startRegular, EndHour = Constants.Constants.endRegular, Cost = Constants.Constants.regularWeekDayRate });
            this.schedules.Add(new ScheduleRule() { Day = Days.WE.ToString(), StartHour = Constants.Constants.startExtra, EndHour = Constants.Constants.endExtra, Cost = Constants.Constants.extraWeekDayRate });
            this.schedules.Add(new ScheduleRule() { Day = Days.WE.ToString(), StartHour = Constants.Constants.startNight, EndHour = Constants.Constants.endNight, Cost = Constants.Constants.nightWeekDayRate });

            this.schedules.Add(new ScheduleRule() { Day = Days.TH.ToString(), StartHour = Constants.Constants.startRegular, EndHour = Constants.Constants.endRegular, Cost = Constants.Constants.regularWeekDayRate });
            this.schedules.Add(new ScheduleRule() { Day = Days.TH.ToString(), StartHour = Constants.Constants.startExtra, EndHour = Constants.Constants.endExtra, Cost = Constants.Constants.extraWeekDayRate });
            this.schedules.Add(new ScheduleRule() { Day = Days.TH.ToString(), StartHour = Constants.Constants.startNight, EndHour = Constants.Constants.endNight, Cost = Constants.Constants.nightWeekDayRate });

            this.schedules.Add(new ScheduleRule() { Day = Days.FR.ToString(), StartHour = Constants.Constants.startRegular, EndHour = Constants.Constants.endRegular, Cost = Constants.Constants.regularWeekDayRate });
            this.schedules.Add(new ScheduleRule() { Day = Days.FR.ToString(), StartHour = Constants.Constants.startExtra, EndHour = Constants.Constants.endExtra, Cost = Constants.Constants.extraWeekDayRate });
            this.schedules.Add(new ScheduleRule() { Day = Days.FR.ToString(), StartHour = Constants.Constants.startNight, EndHour = Constants.Constants.endNight, Cost = Constants.Constants.nightWeekDayRate });

            this.schedules.Add(new ScheduleRule() { Day = Days.SA.ToString(), StartHour = Constants.Constants.startRegular, EndHour = Constants.Constants.endRegular, Cost = Constants.Constants.regularWeekend });
            this.schedules.Add(new ScheduleRule() { Day = Days.SA.ToString(), StartHour = Constants.Constants.startExtra, EndHour = Constants.Constants.endExtra, Cost = Constants.Constants.extraWeekend });
            this.schedules.Add(new ScheduleRule() { Day = Days.SA.ToString(), StartHour = Constants.Constants.startNight, EndHour = Constants.Constants.endNight, Cost = Constants.Constants.nightWeekend });

            this.schedules.Add(new ScheduleRule() { Day = Days.SU.ToString(), StartHour = Constants.Constants.startRegular, EndHour = Constants.Constants.endRegular, Cost = Constants.Constants.regularWeekend});
            this.schedules.Add(new ScheduleRule() { Day = Days.SU.ToString(), StartHour = Constants.Constants.startExtra, EndHour = Constants.Constants.endExtra, Cost = Constants.Constants.extraWeekend });
            this.schedules.Add(new ScheduleRule() { Day = Days.SU.ToString(), StartHour = Constants.Constants.startNight, EndHour = Constants.Constants.endNight, Cost = Constants.Constants.nightWeekend });

        }
    }
}
