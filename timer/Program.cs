// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Threading;
using System.Diagnostics;


public class HelloWorld
{

    public static void Main(string[] args)
    {
        
        Console.WriteLine("enter log mins");
        int enter_log =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter break mins");
        int enter_break = int.Parse(Console.ReadLine());
        bool check_session = true;
        
    
            while (check_session){
          
                if (enter_log >=1 && enter_break >=1){
                    
                    int work_time_in_min = enter_log * 60;
                    // stopwatch.Start();
                    Thread.Sleep(work_time_in_min);
                    // int sum_time += work_time_in_min;
                    
                    Console.WriteLine("time start:");
                    // stopwatch.Stop();
                    // TimeSpan ts = stopwatch.Elapsed;
                        
                    //     Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                    //     ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                        
                for (int i = work_time_in_min; i>=0; i--){
                      Console.WriteLine("Counting down work Time... {0} Second(s)", i);
                      Thread.Sleep(1000);
                      Console.Clear();
                       
                    
                }
               Console.WriteLine("time ends");
                
                Console.WriteLine("running break time");
                
                 int break_time_in_min = enter_break * 60;
                    // stopwatch.Start();
                    
                    
                    Thread.Sleep(break_time_in_min);
                    
                for( int bs = break_time_in_min; bs >=0;bs--){
                    Console.WriteLine("Counting down Rest Time... {0} Second(s)", bs);
                      Thread.Sleep(1000);
                      Console.Clear();
                    
                }
            Console.WriteLine("Rest time completed:");
            Console.WriteLine("To Continue type 1, to end type 2");
            var check_options = Console.ReadLine();
            if (check_options == "1"){
                check_session = true;
            }
            else if (check_options == "2"){
                Console.WriteLine("Godbye buddy");
                break;
                
            }
          
        else{
             Console.WriteLine("ENTER VALID WORK OR BREAK TIME");
        }
            
               
               
                }
            }}
               
               
        
}

