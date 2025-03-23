using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice
{
    public class myDelegates
    {

        // Delegate definition (acts as a function type)
        public delegate void printDelegate(int x);


        //implementation methods (functions that match delegate signature)
        public void PrintWord(int x)
        {
            Console.WriteLine($"Printing value of Word: {x}");
        }

        public void PrintPDF(int x) //implementation
        {
            Console.WriteLine($"Printing value of PDF: {x}");
        }



        // Worker method (takes a function delegate and applies it in a loop)
        public void PrintAllDocumentTypes(printDelegate print)
        {
            for (int i = 0; i < 10; i++)
            {
                print(i); // Calls PrintWord or PrintPDF
            }
        }

        // Executor funciton (calls the worker method with different implementations)
        public void IWantToprinDocuments()
        {
            PrintAllDocumentTypes(PrintWord);
            PrintAllDocumentTypes(PrintPDF);

            printDelegate print = m => Console.WriteLine(m);
            print(10);

        }



    }
}
