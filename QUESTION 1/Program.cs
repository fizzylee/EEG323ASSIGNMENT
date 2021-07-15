using System;

namespace WEEK_1
{
    class Program
    {
        static void Main(string[] args)
        { string course;
          string studentProgram ;
        
         

           Console.WriteLine("Are you a full-time student or a part-time student?");

           studentProgram = Console.ReadLine();

           if (studentProgram == "full-time")
           {
               Console.WriteLine("What is your course of study?");
               course =  Console.ReadLine();

               Console.WriteLine($"{course} is a good course");

           }

           else if (studentProgram == "part-time")
           {
               Console.WriteLine("How many credits are you taking?");

          int credits= Convert.ToInt32(Console.ReadLine());
           
           if (credits > 6)
        Console.WriteLine("Too much units for a part-time student");

        else{
             Console.WriteLine("Proceed");
        }
           }




           
        }
    }
}