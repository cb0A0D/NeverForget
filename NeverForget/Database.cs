using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{

    /// <summary>
    /// In memory database
    /// </summary>
    class Database
    {
        /// <summary>
        /// Appointment Entries
        /// </summary>
        private List<Entry> entries;

        /// <summary>
        /// Initializes instance
        /// </summary>
        public Database()
        {
            entries = new List<Entry>();
        }

        /// <summary>
        /// Adds new entry
        /// </summary>
        /// <param name="occurs">Date and time</param>
        /// <param name="text">Entry text</param>
        public void AddEntry(DateTime occurs, string text)
        {
            entries.Add(new Entry(occurs, text));
        }

        /// <summary>
        /// Searches for entries that occur on given date and time
        /// </summary>
        /// <param name="date">Date and time</param>
        /// <param name="byTime">Whether we want to search by time too</param>
        /// <returns></returns>
        public List<Entry> FindEntries(DateTime date, bool byTime)
        {
            List<Entry> found = new List<Entry>();
            foreach (Entry entry in entries)
            {
                if (((byTime) && (entry.Occurs == date)) // by time and date
                ||
                ((!byTime) && (entry.Occurs.Date == date.Date))) // by date only
                    found.Add(entry);
            }
            return found;
        }

        /// <summary>
        /// Removes entries occurring on given date and time
        /// </summary>
        /// <param name="date">Date and time</param>
        public void DeleteEntries(DateTime date)
        {
            List<Entry> found = FindEntries(date, true);
            foreach (Entry entry in found)
                entries.Remove(entry);
        }

    }
}

