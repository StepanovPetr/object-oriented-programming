using _009_Enums.Enums;

namespace _009_Enums
{
    class MyTask
    {
        private WeekDays _dayOfWeek;
        private string _taskOfDay;

        public MyTask(WeekDays dayOfWeek, string taskOfDay = "")
        {
            this._dayOfWeek = dayOfWeek;
            this._taskOfDay = taskOfDay;
        }

        public string Message => $"{_dayOfWeek} {(int)_dayOfWeek} я должен сделать {_taskOfDay}";
    }
}