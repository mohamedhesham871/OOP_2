namespace ConsoleApp2
{
    internal class Program
    {
        #region Q1 Enum WeekDay
        enum weekDays
        {
            MonDay,
            TuesDay,
            WednesDay,
            ThursDay,
            FriDay,
            SaturDay,
            SunDay
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1: create Enum call WeekDays
           foreach (weekDays week in Enum.GetValues(typeof(weekDays)))
                Console.WriteLine(week);

           // Another solve using var and GetNames
           foreach( var week in Enum.GetNames(typeof(weekDays)))
                Console.WriteLine(week);

            #endregion

        }
    }
}
