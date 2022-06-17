using System;

namespace FactoryPatternExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yooooo! Whict type of database you tryna use: List, SQL, or Mono?");
            var programmerAnswer = Console.ReadLine();

            IDataAccess programmer1 = DataAccessFactroy.GetDataAccessType(programmerAnswer);
            programmer1.SaveData();
            programmer1.LoadData();
        }
    }
}
