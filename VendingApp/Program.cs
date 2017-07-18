using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VendingApp
{
    /// <summary>
    /// Very rough and ready way to interact with the model for testing and demonstration.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IConsoleWrapper consoleWrapper = new ConsoleWrapper();
            var consoleView = new ConsoleView(consoleWrapper);

            consoleView.StartConsoleView();
        }

        
    }
}
