namespace AcmeSchedule.Model
{
    public class ScheduleWork : Schedule
    {
        public int numberOfHours { get; set; }

        public bool hasError { get; set; } = false;
    }
}