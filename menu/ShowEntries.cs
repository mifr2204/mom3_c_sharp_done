using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mom3.menu
{
    internal class ShowEntries
    {

        //menu main function
        public void run()
        {
            this.print();

            //read input key from console
            ConsoleKeyInfo consoleInput = Console.ReadKey();

            this.input(consoleInput);
        }

        //Prints information to screen
        public void print()
        {
            Console.WriteLine("# : Namn : Meddelande");
            Console.WriteLine("=======");
            Guestbook guestbook = new Guestbook();

            Console.Clear();
            List<GuestBookEntry> entries = guestbook.getEntries();
            for (int i = 0; i < entries.Count; i++)
            {
                Console.WriteLine("Gästbok inlägg");
                Console.WriteLine("===================");
                GuestBookEntry entry = entries[i];
                Console.WriteLine(string.Concat(i.ToString(), " : ", entry.Name, " : ", entry.Text));
            }

            if (entries.Count == 0)
            {
                Console.WriteLine("Gästboken är tom");
            }
            Console.WriteLine("===================");
            Console.WriteLine("Tryck på m för att återgå till huvudmenyn eller r för att radera ett inlägg");
            ConsoleKey k = Console.ReadKey().Key;
            if (k == ConsoleKey.M)
            {
                return;
            }
            else if (k == ConsoleKey.R)
            {
                Console.WriteLine();
                RemoveEntry removeEntry = new RemoveEntry();
                removeEntry.run(false);
                return;
            }
        }

        //Handles user input if any
        public void input(ConsoleKeyInfo consoleInput)
        {
            return;
        }

    }
}
