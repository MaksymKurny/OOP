using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_4
{
    public class CPU
    {
        public string Number, Segment;
        public int Core, Year;
        public double BFrequency, TFrequency;
        public bool HyperT;
        public int GetNumberOfThreads()
        {
            if (HyperT == true) return (Core * 2);
            else return (Core);
        }
    }
}