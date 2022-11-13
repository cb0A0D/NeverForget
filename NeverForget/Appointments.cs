using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    /// <summary>
    /// Represents appointments layer at top of console 
    /// </summary>
    class Appoint
    {
        /// <summary>
        /// Database instance
        /// </summary>
        private Database database;

        /// <summary>
        /// Initializes instance
        /// </summary>
        public Appoint()
        {
            database = new Database();
        }

        /// <summary>
        /// User enters date and time and returns this value.It keeps asking user until valid value is entered.
        /// </summary>
        /// <returns>Entered date and time</returns>
        private DateTime ReadDateTime()
        {
            Console.WriteLine("Enter date and time as e.g. [01/10/2022 14:00]:");
            DateTime dateTime;
            while (!DateTime.TryParse(Console.ReadLine(), out dateTime))
                Console.WriteLine("Error. That's not going to work. Please try again: ");
            return dateTime;
        }

        /// <summary>
        /// Prints all entries occurring on given day
        /// </summary>
        /// <param name="day">Day</param>
        public void PrintEntries(DateTime day)
        {
            List<Entry> entries = database.FindEntries(day, false);
            foreach (Entry entry in entries)
                Console.WriteLine(entry);
        }

        /// <summary>
        /// Asks user for new entry and adds it into database
        /// </summary>
        public void AddEntry()
        {
            DateTime dateTime = ReadDateTime();
            Console.WriteLine("Enter the entry text:");
            string text = Console.ReadLine();
            database.AddEntry(dateTime, text);
            Console.WriteLine("Entry Successfully Added");
            Console.WriteLine();
        }

        /// <summary>
        /// Lets user search for entries on day he enters
        /// </summary>
        public void SearchEntries()
        {
            // Entering date by user
            DateTime dateTime = ReadDateTime();
            // Searching for entries
            List<Entry> entries = database.FindEntries(dateTime, false);
            // Printing entries
            if (entries.Count() > 0)
            {
                Console.WriteLine("Yea! I found entries: ");
                foreach (Entry entry in entries)
                    Console.WriteLine(entry);
            }
            else
                // Nothing found
                Console.WriteLine("Sorry, no entries were found.");
        }

        /// <summary>
        /// Lets user to delete entries on the day entered
        /// </summary>
        public void DeleteEntries()
        {
            Console.WriteLine("Entries with exact date and time will be deleted");
            DateTime dateTime = ReadDateTime();
            database.DeleteEntries(dateTime);
        }

        /// <summary>
        /// Prints application home screen
        /// </summary>
        public void PrintHomeScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to NeverForget!");
            Console.WriteLine("Today is: {0}", DateTime.Now);
            Console.WriteLine();
            // printing the home screen
            Console.WriteLine("Today:\n------");
            PrintEntries(DateTime.Today);
            Console.WriteLine();
            Console.WriteLine("Tomorrow:\n---------");
            PrintEntries(DateTime.Now.AddDays(1));
            Console.WriteLine();
        }

    }
}

