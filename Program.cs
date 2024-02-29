using mom3.menu;
using System.Runtime.InteropServices;

namespace mom3
{

    class Program
    {

        //Program main entry point
        static void Main(string[] args)
        {

            //create a new main menu
            MainMenu mainMenu = new MainMenu();

            //loop forever
            while (true)
            {
                mainMenu.run();
            }


        }
    }


}