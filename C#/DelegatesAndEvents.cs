using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesAndEvents
{
    public enum WorkType {coding, ui, meeting};

    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

            //Eventhandler method
            worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);

            worker.DoWork(8, WorkType.coding);
        }

        //Standalone event handler method
        static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine(e.Hours + " : " + e.WorkType);
        }

        //Standalone event handler method
        static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work completed");
        }
    }


    public class Worker
    {
        //Events
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted; //EventHandler is a build in delegate

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, WorkType.coding);
            }

            OnWorkCompleted();
        }

        private void OnWorkPerformed(int hours, WorkType workType)
        {
            if (WorkPerformed != null)
            {
                WorkPerformed(this, new WorkPerformedEventArgs(hours, workType));
            }
        }

        private void OnWorkCompleted()
        {
            if (WorkCompleted != null)
            {
                WorkCompleted(this, EventArgs.Empty);
            }
        }
    }


    public class WorkPerformedEventArgs : EventArgs
    {
        public WorkPerformedEventArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = workType;
        }

        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}