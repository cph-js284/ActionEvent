using System;
using System.Threading;

namespace ActionEvent
{
    public class EventSender
    {
        public event Action<MyEventArgs> ActionEvent;

        public void DoWork(int waitForSec, string name){
            System.Console.WriteLine($"starting work {name}");
            Thread.Sleep(waitForSec*1000);
            SendEvent(name);
        }

        public void SendEvent(string name){
            MyEventArgs mea = new MyEventArgs();
            mea.Info="work done : " + name;
            ActionEvent.Invoke(mea);
        }
    }


    public class MyEventArgs : EventArgs
    {
        public string Info { get; set; }
    }

}