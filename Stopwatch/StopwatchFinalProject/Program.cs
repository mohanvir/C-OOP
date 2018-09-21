using System;

namespace StopwatchFinalProject{
    public class StopWatch{

        private DateTime start;
        private DateTime stop;
        public bool flag = false;

        public void Start(){
          this.start = DateTime.Now;
            this.flag = true;
        }

        public DateTime retrieveStart(){
            return this.start;
        }

        public void Stop(){
            this.stop = DateTime.Now;
            this.flag = false;
            TimeSpan X = this.stop - this.start;

            Console.WriteLine("total time taken was: {0}", X);
        }
    }


    class MainClass{
        public static void Main(string[] args){

            Console.WriteLine("This apps goal is to function as a timer.\n You have four options, Start, Stop, Reset, and Done");
            StopWatch Watch = new StopWatch();

           string input= Console.ReadLine();
            while (input != "done" || input != "Done"){

                if (input == "start"){
                    if (Watch.flag == false){
                        Watch.Start();
                    }
                    else{
                        Console.WriteLine("Timer is already Started. You cannot restart the Timer");
                    }

                }
                else if (input =="stop"){
                    Watch.Stop();
                }
                else if (input =="reset") {


                }
                Console.WriteLine("next input: ");
                input = Console.ReadLine();
            }
        } 
    }
}
