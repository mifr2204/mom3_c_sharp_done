using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mom3.menu
{
    internal class AddEntry
    {

        //menu main function
        public void run()
        {
            Console.Clear();
            Console.WriteLine("Skriv ett gästboksinlägg");
            Console.WriteLine("=======");

            //read input string from console
            Console.WriteLine("Vad är ditt namn?");
            string? nameInput = Console.ReadLine();

            //empty input makes this method execute again from the beginning
            if (string.IsNullOrEmpty(nameInput))
            {
                Console.WriteLine("Fältet får ej vara tomt, testa igen genom att trycka på valfri knapp");
                Console.ReadKey();
                this.run();
                return;
            }


            //read input string from console
            Console.WriteLine("Ditt meddelande:");
            string? textInput = Console.ReadLine();

            //empty input makes this method execute again from the beginning
            if (string.IsNullOrEmpty(nameInput))
            {
                Console.WriteLine("Fältet får ej vara tomt, testa igen genom att trycka på valfri knapp");
                Console.ReadKey();
                this.run();
                return;
            }

            //create a new GuestBookEntry instance
            GuestBookEntry guestBookEntry = new()
            {
                Name = nameInput,
                Text = textInput
            };

            //add the GuestBookEntry to the guestbook
            Guestbook guestbook = new();
            guestbook.addEntry(guestBookEntry);


            //output confirmation message to the console
            Console.WriteLine("Ditt meddelande är sparat, tryck på valfri knapp för att återgå till huvudmenyn...");
            Console.ReadKey();
            return;
     
        }


    }
}
