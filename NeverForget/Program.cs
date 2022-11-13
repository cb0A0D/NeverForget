using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Appointsments instance
            Appoint appoint = new Appoint();
            char choice = '0';
            // main loop
            while (choice != '4')
            {
                appoint.PrintHomeScreen();
                Console.WriteLine();
                Console.WriteLine("What would you like to do?:");
                Console.WriteLine("1 - Add an entry");
                Console.WriteLine("2 - Search for entries");
                Console.WriteLine("3 - Delete entries");
                Console.WriteLine("4 - End");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // reaction to the choice
                switch (choice)
                {
                    case '1':
                        appoint.AddEntry();
                        break;
                    case '2':
                        appoint.SearchEntries();
                        break;
                    case '3':
                        appoint.DeleteEntries();
                        break;
                    case '4':
                        Console.WriteLine("Press any key to leave the program.");
                        break;
                    default:
                        Console.WriteLine("Error. Have you had your coffee yet? Press any key to choose another action.");
                        break;
                }
                Console.Write("Press Any Key to Continue");
                Console.ReadKey();
            }
        }
    }
}
