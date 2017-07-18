using System;

namespace VendingApp
{
    internal interface IConsoleWrapper
    {
        void WriteLine(string lineToWrite);

        string ReadLine();
    }

    /// <summary>
    /// This wrapper will allow us to mock console calls, meaning everything else can be tested
    /// </summary>
    internal class ConsoleWrapper : IConsoleWrapper
    {
        public void WriteLine(string lineToWrite)
        {
            Console.WriteLine(lineToWrite);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

    }

}