using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Alarm
    {
        public uint hours;
        public uint minutes;
        public uint alarmTimeHours;
        public uint alarmTimeMinutes;

        public Alarm(uint hours, uint minutes, uint alarmTimeHours, uint alarmTimeMinutes)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.alarmTimeHours = alarmTimeHours;
            this.alarmTimeMinutes = alarmTimeMinutes;

        }

        public Alarm(string time0, string time)
        {
            string[] s = time.Split(':');
            alarmTimeHours = Convert.ToUInt32(s[0]);
            alarmTimeMinutes = Convert.ToUInt32(s[1]);
            string[] s0 = time0.Split(':');
            hours = Convert.ToUInt32(s0[0]);
            minutes = Convert.ToUInt32(s0[1]);
         

        }
        private void Ring()
        {
            Console.WriteLine("ring");
        }

        public uint CheckTimeLeft()
        {
            uint time1 = hours * 60 + minutes;
            uint time2 = alarmTimeHours * 60 + alarmTimeMinutes;

            if (time2 - time1 <= 0)
            {
                Ring();
                return 0;             
            }
            else
            {
                return time2 - time1;
            }
        }
    }
}
