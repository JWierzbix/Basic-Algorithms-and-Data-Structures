using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Course_Selection_Problem_GREEDY_PROGRAMMING
{
    public class Program
    {  
        static void Main(string[] args)
        {
            Course Architecture = new Course("Architecture", 10, 12);
            Course Electronics = new Course("Electronics", 14,16);
            Course Programming = new Course("Programming", 9,13);
            Course Philosophy = new Course("Philosophy", 14,15);
            Course BHP = new Course("BHP", 10,11);
            Course Calculus = new Course("Calculus", 12,14);
            Course Economy = new Course("Economy", 15,16);
            Course AI = new Course("AI", 8,10);
            Course[] plan = { Architecture, Electronics, Programming, Philosophy, BHP, Calculus, Economy, AI };
            Schedule(plan);
            Console.ReadKey();
        }
        public static void Schedule(Course[] list)
        {
            Array.Sort(list);
            ArrayList schedule = new ArrayList();
            int finishHour = 0;
            int duration = 0;
            foreach (Course c in list)
            {
                if(c.start >= finishHour)
                {
                    schedule.Add(c);
                    duration += c.Duration;
                    finishHour = c.finish;
                }
            }
            Console.WriteLine($"The day consists of {schedule.Count} courses which lasts {duration} and the whole day ends at {finishHour} a.m.");
            foreach(Course c in schedule)
            {
                Console.WriteLine($"Course: *{c.name}*     duration: {c.Duration} time: {c.start} - {c.finish}");
            }
        }
    }
    public class Course : IComparable
    {
        public int start;
        public int finish;
        public string name;
        public int Duration => finish - start;
        public Course(string name, int s, int f)
        {
            this.name = name;
            start = s;
            finish = f;
        }

        public int CompareTo(object obj)
        {
            if (((Course)obj).start > start) return -1;
            else if (((Course)obj).start == start) return 0;
            else return 1;
        }
    }
}
