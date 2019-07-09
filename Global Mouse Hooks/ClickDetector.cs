using Global_Mouse_Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gma.System.MouseKeyHook;
using System.Windows.Forms;

namespace Global_Mouse_Hooks
{
    public class ClickDetector
    {
        public static void ListenForMouseEvents()
        {
            Console.WriteLine("Listening to mouse clicks.");

            //When a mouse button is pressed 
            Hook.GlobalEvents().MouseDown += async (sender, e) =>
            {
                Console.WriteLine($"Mouse {e.Button} Down");
                Console.WriteLine("Co-ordinates of Mouse: "+e.X + " "+e.Y);
            };
            //When a double click is made
            Hook.GlobalEvents().MouseDoubleClick += async (sender, e) =>
            {
                Console.WriteLine($"Mouse {e.Button} button double clicked.");
                Console.WriteLine("Co-ordinates of Mouse: " + e.X + " " + e.Y);
            };
        }
    }
}
