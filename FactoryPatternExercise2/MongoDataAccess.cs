using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from mongo database");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a mongo database");
        }
    }
}
