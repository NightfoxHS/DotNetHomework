using System;
using System.Threading;

namespace Homework4_2
{
    public struct TimeArgs
    {
        public int Hour{ get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public static bool operator==(TimeArgs r,TimeArgs l)
        {
            if (r.Hour == l.Hour && r.Minute == l.Minute && r.Second == l.Second)
                return true;
            else
                return false;
        }
        public static bool operator !=(TimeArgs r, TimeArgs l)
        {
            if (r.Hour == l.Hour && r.Minute == l.Minute && r.Second == l.Second)
                return false;
            else
                return true;
        }

    }

    public delegate void ClockHandler(object sender, TimeArgs time);

    public class Clock
    {
        public TimeArgs time;
        public TimeArgs alarmTime;

        public event ClockHandler OnTick;
        public event ClockHandler OnAlarm;

        public Clock(int hour,int minute)
        {
            try
            {
                if (hour < 24 && hour >= 0 && minute < 60 && minute >= 0)
                {
                    time.Hour = hour;
                    time.Minute = minute;
                    time.Second = 0;
                }
                else
                    throw new Exception("Input time occurs error");
            }
            catch(Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void SetClock(int hour, int minute)
        {
            try
            {
                if (hour < 24 && hour >= 0 && minute < 60 && minute >= 0)
                {
                    time.Hour = hour;
                    time.Minute = minute;
                    time.Second = 0;
                }
                else
                    throw new Exception("Input time occurs error");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void SetAlarm(int hour, int minute)
        {
            try
            {
                if (hour < 24 && hour >= 0 && minute < 60 && minute >= 0)
                {
                    alarmTime.Hour = hour;
                    alarmTime.Minute = minute;
                    alarmTime.Second = 0;
                }
                else
                    throw new Exception("Input time occurs error");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void RunStep()
        {
            if (time.Second < 59)
                time.Second++;
            else
            {
                time.Second = 0;
                time.Minute++;
                if (time.Minute > 59)
                {
                    time.Minute = 0;
                    time.Hour = (time.Hour + 1) % 24;
                }
            }
            if (time == alarmTime)
            {
                OnAlarm(this, time);
                OnTick(this, time);
            } 
            else
                OnTick(this, time);
            Thread.Sleep(1000);
        }

        public void Run()
        {
            while (true)
            {
                RunStep();
            }
        }
    }

    class MyClock
    {
        public static void OnTick1(object sender,TimeArgs time)
        {
            Console.WriteLine($"{time.Hour}:{time.Minute}:{time.Second}");
        }
        public static void OnAlarm1(object sender, TimeArgs time)
        {
            Console.WriteLine("Ding!");
        }
        static void Main(string[] args)
        {
            Clock clock = new Clock(0, 0);
            clock.SetAlarm(0, 1);
            clock.OnTick += OnTick1;
            clock.OnAlarm += OnAlarm1;
            clock.Run();
        }
    }
}
