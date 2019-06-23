using System;
using System.Threading.Tasks;

namespace ActionEvent
{
    class Program
    {


        static void print(MyEventArgs msg){
            System.Console.WriteLine(msg.Info);
        }

        static void Main(string[] args)
        {
            EventSender ES = new EventSender();
            ES.ActionEvent += print;
            //alternative
            //ES.ActionEvent += (Eargs) => {System.Console.WriteLine(Eargs.Info);};


            //starting 2 workers
            Task.Run(()=>ES.DoWork(3,"worker1"));
            Task.Run(()=>ES.DoWork(2,"worker2"));

            //wait for it...
            Console.ReadKey();

        }
    }
}
