using System;
using _010_Enums.Enums;

namespace _010_Enums
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

        public string Message => $"{(int)this._dayOfWeek} я должен сделать {this._taskOfDay}";
    }
}