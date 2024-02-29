using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace mom3.menu
{
    internal class RemoveEntry
    {

        //menu main function
        public void run(bool clear = true)
        {
            //clear the console window if clear is true
            if (clear) {
                Console.Clear();
                Console.WriteLine("Radera ett gästboksinlägg");
                Console.WriteLine("=======");
            }

            Console.WriteLine("Skriv ID för post att radera: (eller lämna tom för att ångra)");

            //read input string from console
            string? idInput = Console.ReadLine();

            //exit if input is empty
            if (string.IsNullOrEmpty(idInput))
            {
                return;
            }
           
            int id = int.Parse(idInput);
            Guestbook guestbook = new();

            //id is index - if input value is above list count then it is wrong
            if (guestbook.getEntries().Count < id)
            {
                Console.WriteLine("Det finns ingen post med detta id");
                Console.ReadKey();   
                return;
            }

            //remove entry with specified index
            GuestBookEntry entry = guestbook.getEntries()[id];
            guestbook.removeEntry(entry);


            //write success message to console and await key input for confirmation
            Console.WriteLine("Valt meddelande är raderat, tryck på valfri knapp för att återgå till huvudmenyn...");
            Console.ReadKey();
        }


    }
}
