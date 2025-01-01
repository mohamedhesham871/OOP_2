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
        //enum Season
        //{
        //    Spring=1, 
        //    Summer=2,
        //    Autumn=3,
        //    Winter=4
        //}


        #endregion
        #region Q4 Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
        //[Flags]
        //enum Permission:Byte
        //{
        //        None=0,
        //        Read=1,
        //        Write=2,
        //        Delete=4,
        //        Execute=8

        //}

        #endregion
        #region Q5 :Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
        //enum Colors
        //{
        //    Red,
        //    Green,
        //    Blue
        //}
        #endregion
        #region Q6 :
        struct Point {
            public double x;
            public double y;
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
            #region Q3 Season Enum
            // string input=Console.ReadLine();
            // bool h = Enum.TryParse(input ,out Season season);
            // if (!h) { Console.WriteLine("Invalid input"); }

            //switch(season)
            // {
            //     case Season.Spring:
            //         Console.WriteLine("Months : March , April,  May ");
            //         break;
            //     case Season.Summer:
            //         Console.WriteLine("Months : June , July , August ");
            //         break;
            //     case Season.Autumn:
            //         Console.WriteLine("Months : September, October, November ");
            //         break;
            //     case Season.Winter:                        
            //         Console.WriteLine("Months :   December , January , February ");
            //           break;
            // }

            #endregion
            #region Q4 Permissions (Read, write, Delete, Execute)

            //Permission permession = Permission.Read|Permission.Delete;
            //Console.WriteLine(permession);
            ////if foud Delete will delete it else will Add it
            //permession ^= Permission.Delete;
            ////Cheak if it Foud or not
            //permession &= Permission.Delete;
            //Console.WriteLine(permession);
            #endregion
            #region Q5 Enum of Color
            //string Input = Console.ReadLine();
            //if(Enum.TryParse(Input,out Colors color))
            //{
            //    Console.WriteLine($"Primary Color is {color}");
            //}
            //else
            //{
            //    Console.WriteLine("it's not Primary Color");
            //}
            #endregion
            #region Q6 :Create a struct called "Point" to represent a 2D point with properties "X" and "Y"
            Point pt1 = new Point();
            Point pt2= new Point();
            Console.WriteLine("Enter x and Y for First Point");
            string Input = Console.ReadLine();
            //Point one 
            pt1.x=double.Parse(Input.Split(' ')[0]);
            pt1.y=double.Parse(Input.Split(' ')[1]);
            Console.WriteLine("Enter x and Y for Second Point");
             Input = Console.ReadLine();
            pt2.x = double.Parse(Input.Split(' ')[0]);
            pt2.y = double.Parse(Input.Split(' ')[1]);

            //Calculate Distance 
            double Distance = Math.Sqrt(Math.Pow(pt2.x - pt1.x, 2) + Math.Pow(pt2.y - pt1.y, 2));
            Console.WriteLine($"Distance Between Two Points is :{Distance}");
            #endregion
        }
    }
}
