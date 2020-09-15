using System;
using System.Windows.Forms;

namespace AlertME.App
{
    public class Alarms
    {
        public Timer tmr1; //TODO: burayı propertye çevirmelisin
        public Alarms(int y, int m, int d, int h, int mu, string text, string name) //Constructor
        {
            Year = y;
            Month = m;
            Day = d;
            Hours = h;
            Munites = mu;
            MessageInTxt = text;
            Name = name;
            tmr1 = new Timer()
            {
                Interval = Convert.ToInt32(TotalMilliSecond),
                Enabled = true,
                Tag = MessageInTxt
            };
        }

        public string Name { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public int Munites { get; set; }

        public DateTime date
        {
            get
            {
                return new DateTime(Year, Month, Day, Hours, Munites, 0);
            }
        }
        public double TotalMilliSecond
        {
            get
            {
                return (date - DateTime.Now).TotalMilliseconds;
            }            
        }
        public string MessageInTxt { get; set; }
        
        



        public override string ToString()
        {
            var text = date.Day < 10 ? $"{Name} ---  {date}" : $"{Name} --- {date}";
            return text;
        }

    }
}
