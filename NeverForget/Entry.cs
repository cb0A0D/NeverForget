using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    /// <summary>
    /// Represents Appointment entry
    /// </summary>
    class Entry
    {
        /// <summary>
        /// The Date and time
        /// </summary>
        public DateTime Occurs { get; set; }
        /// <summary>
        /// Entry text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Initializes instance
        /// </summary>
        /// <param name="occurs">Date and time</param>
        /// <param name="text">Entry text</param>
        public Entry(DateTime occurs, string text)
        {
            Occurs = occurs;
            Text = text;
        }

        /// <summary>
        /// Returns entry string representation
        /// </summary>
        /// <returns>Entry string representation</returns>
        public override string ToString()
        {
            return Occurs + " " + Text;
        }
    }
}

