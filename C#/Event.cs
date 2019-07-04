using System;

namespace Event
{
    public class SampleEventArgs
    {
        public string Text { get; } //Readonly

        public SampleEventArgs(string text)
        {
            Text = text;
        }
    }

    public class Publisher
    {
        //Declare the delegate
        public delegate void SampleEventHandler(object sender, SampleEventArgs e);

        //Declare the event
        public event SampleEventHandler SampleEvent;

        //Wrap the event in a protected virtual method to enable derived classes to raise the event
        protected virtual void RaiseSampleEvent()
        {
            //Raise the event
            if (SampleEvent != null)
            {
                SampleEvent(this, new SampleEventArgs("Hello"));
            }
        }
    }
}
