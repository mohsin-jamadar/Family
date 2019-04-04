using System;
using System.Collections.Generic;
using Family.Core.Interfaces;

namespace Family.Core
{
    public  class ConsoleOutput : IOutput
    {
        public void GenerateOutput(List<string> output)
        {
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            
        }
       
    }
}
