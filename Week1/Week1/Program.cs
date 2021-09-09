using System;

namespace Week1
{
    public class Program
    {
       public static void Main(string[] args)
        {

            //Displays message to the user
            Console.WriteLine("Enter a year!");

            int converInput; 
            var year = Console.ReadLine();
            var succes = int.TryParse(year, out converInput);

            if(succes == true){
                if (converInput < 1582){
                    Console.WriteLine("Please select a year higher then 1582");
                
                }else if (Is_Leap_Year(converInput)){
                    Console.WriteLine("yay");
                }else{
                    Console.WriteLine("nay");
                }
            }else{
                Console.WriteLine("Please enter year as a number!");
            }
        
        }
           
            
            //Console.WriteLine(Is_Leap_Year(2000));
        

        public static bool Is_Leap_Year(int year){
            if (year % 400 == 0) {
                //If its leap year
                return true;
            }else if (year % 100 == 0){
                //It is not leap year
                return false;
            }else if (year % 4 == 0){

                //It is leap year
                return true;
            }
            //If it is not leap year
            return false;


        }
    }
}
