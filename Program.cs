using System.Drawing;

namespace ConsoleApp2
{
    internal class Program
    {
        #region Q1 Enum WeekDay
        //enum weekDays
        //{
        //    MonDay,
        //    TuesDay,
        //    WednesDay,
        //    ThursDay,
        //    FriDay,
        //    SaturDay,
        //    SunDay
        //}
        #endregion

        #region Q2 : Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. 
        ////      Then, write a C# program to display the details of all the persons in the array
        //struct person
        //{
        //    public string Name;
        //    public int Age;
        //}
        #endregion

        #region Q3 :make enum for season 
        enum Season
        {
            Spring=1, 
            Summer=2,
            Autumn=3,
            Winter=4
        }
        enum monthes {
            
            
            
            
          
        }

        #endregion
        static void Main(string[] args)
        {
            #region Q1: create Enum call WeekDays
            //foreach (weekDays week in Enum.GetValues(typeof(weekDays)))
            //     Console.WriteLine(week);

            //// Another solve using var and GetNames
            //foreach( var week in Enum.GetNames(typeof(weekDays)))
            //     Console.WriteLine(week);

            #endregion
            #region Q2: struct call person
            //person[] person =  new person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter Name of prson {i + 1}");
            //    person[i].Name = Console.ReadLine();
            //    Console.WriteLine($"Enter Age of Person {i + 1}");
            //    person[i].Age = int.Parse(Console.ReadLine());
            //}
            //foreach (person i in person)
            //{
            //    Console.WriteLine($"Student Name is : {i.Name} and Age is {i.Age}");
            //}

            #endregion
            #region MyRegion
            string input=Console.ReadLine();
            bool h = Enum.TryParse(input ,out Season season);
            if (!h) { Console.WriteLine("Invalid input"); }
            
           switch(season)
            {
                case Season.Spring:
                    Console.WriteLine("Months : March , April,  May ");
                    break;
                case Season.Summer:
                    Console.WriteLine("Months : June , July , August ");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Months : September, October, November ");
                    break;
                case Season.Winter:                        
                    Console.WriteLine("Months :   December , January , February ");
                      break;
            }

            #endregion
        }
    }
}
