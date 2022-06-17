using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from SQL database");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }
    }
}
