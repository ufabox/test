// this is a line of comments
//  ljgkldfgklfgfghjkfjkhfghfgjkfjgfghfhgjkhfjkhjkhjkhjkhjkhjkjkh
using System;
using System..Collections.Generic;
using System..Linq;
using System..Threading.Tasks;


namespace ConsoleApp1
{
    public class Program
    {

        public class SamplesDelegate
        {
            // Declares a delegate for a method that takes in an int and returns a String.
            public delegate string MyMethodDelegate(DateTime myDate);

            // Defines some methods to which the delegate can point.
            public class MySampleClass
            {

                // Defines an instance method.
                public string MyDayofWeekMethod(DateTime myDate)
                {
                    return (myDate.DayOfWeek.ToString());
                }

                // Defines a static method.
                public static string MyActivityMethod(DateTime myDate)
                {
                    switch (myDate.DayOfWeek)
                    {
                        case DayOfWeek.Saturday:
                        case DayOfWeek.Sunday:
                            return ("just relaxing...");
                        default:
                            return ("working hard...");
                    }
                }
            }
        }

        public static void Main()
            {
                DateTime today = new DateTime(2015, 12, 18);

            // Creates one delegate for each method. For the instance method, an
                // instance (mySC) must be supplied. For the static method, use the
                // class name.
                SamplesDelegate.MySampleClass mySc = new SamplesDelegate.MySampleClass();
                SamplesDelegate.MyMethodDelegate myD1 = new SamplesDelegate.MyMethodDelegate(mySc.MyDayofWeekMethod);
                SamplesDelegate.MyMethodDelegate myD2 = new SamplesDelegate.MyMethodDelegate(SamplesDelegate.MySampleClass.MyActivityMethod);

                // Invokes the delegates.
                Console.WriteLine("Today is {1}, so I am {2}.", 5, myD1(today), myD2(today));
            }
        }

}
