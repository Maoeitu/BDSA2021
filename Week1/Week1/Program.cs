using System;

namespace Week1
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Is_Leap_Year(2020);
            
            Console.WriteLine(Is_Leap_Year(2000));
        }

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
