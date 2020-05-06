using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class PrinterWindows
    {
        public string Merk { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("\n");
        }
        
        public virtual void Print()
        {
            Console.WriteLine("\n");
        }
    }
}
