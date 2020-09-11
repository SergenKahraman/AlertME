using System;
using System.Windows.Forms;

namespace AlertME.App
{
    public class Alarms
    {
        public string Name;
        public int Year, Month, Day, Hours, Munites;
        public DateTime date;
        public double TotalMilliSecond;
        public string MessageInTxt;
        public Timer tmr1;

        public Alarms(int y, int m, int d, int h, int mu, string text, string name)
        {
            Year = y;
            Month = m;
            Day = d;
            Hours = h;
            Munites = mu;
            MessageInTxt = text;
            Name = name;
            date = new DateTime(Year, Month, Day, Hours, Munites, 0);
            TotalMilliSecond = (date - DateTime.Now).TotalMilliseconds;
            tmr1 = new Timer()
            {
                Interval = Convert.ToInt32(TotalMilliSecond),
                Enabled = true,
                Tag = MessageInTxt
            };
        }

        

        public override string ToString()
        {
            var text = date.Day < 10 ? $"{Name} ---  {date}" : $"{Name} --- {date}";
            return text;
        }

    }
}
