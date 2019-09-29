using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 009_Operators
{
    class Task
    {
        private DayOfWeek _dayOfWeek;
        private string _taskOfDay;

        public Task(DayOfWeek dayOfWeek, string taskOfDay = "")
        {
            this._dayOfWeek = dayOfWeek;
            this._taskOfDay = taskOfDay;
        }

        public string Message { get { return $"{(int)this._dayOfWeek} я должен сделать {this._taskOfDay}";} }
        //public string Message { get { return $"{(int)this._dayOfWeek} я должен сделать {this._taskOfDay}"; } }

    }
}
