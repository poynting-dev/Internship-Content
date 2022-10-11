using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class DataAccess
    {
        public void insertData()
        {
            Console.WriteLine("Data successfully into the DB");
        }
    }

    public class DataLogger
    {
        public void writeLog()
        {
            Console.WriteLine("Logged time: " + DateTime.Now.ToShortTimeString() + "\n LogData insertion successfully.");
        }
    }

    public class singleResponsibilty
    {
        public void print()
        {
            DataAccess dataAccess = new DataAccess();
            DataLogger logger = new DataLogger();
            dataAccess.insertData();
            logger.writeLog();
        }   
    }


    //Not Following the Single Responsibilty Principle
    //class DataAccess
    //{
    //    public static void InsertData()
    //    {
    //        Console.WriteLine("Data inserted into database successfully");
    //        Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " Log  Data insertion completed successfully");
    //    }
    //}
}
