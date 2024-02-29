using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mom3.menu
{
    internal class MainMenu
    {

        //menu main function
        public void run()
        {
            this.print();

            //read input key from console
            ConsoleKeyInfo consoleInput = Console.ReadKey();

            this.input(consoleInput);
        }

        //prints information to screen
        public void print()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till gästboken");
            Console.WriteLine("=======");
            Console.WriteLine("1. Visa/radera gästboksinlägg");
            Console.WriteLine("2. Skriv ett gästboksinlägg");
            Console.WriteLine("3. Avsluta");
        }

        //handles user input
        public void input(ConsoleKeyInfo input)
        {
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    this.ShowEntries();
                    break;
                case ConsoleKey.D2:
                    this.AddEntry();
                    break;
                case ConsoleKey.D3:
                    this.Shutdown();
                    break; 
            }
        }
        
        //exit the program
        private void Shutdown()
        {
            Environment.Exit(0);
        }

        //open menu for showing entries
        private void ShowEntries()
        {
            menu.ShowEntries menu = new();
            menu.run();
        }

        //open menu for adding new entries
        private void AddEntry()
        {
            AddEntry menu = new();
            menu.run();
        }

        //open menu for removing entries
        private void RemoveEntry()
        {
            RemoveEntry menu = new();
            menu.run();
        }

    }
}
