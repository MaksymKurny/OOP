using System;

namespace oop_lab_2a
{
    public class CPU
    {
        public string Number, Segment;
        public int Core, Year;
        public double BFrequency, TFrequency;
        public bool HyperT;

        public int NumberOfThreads
        {
            get
            {
                return GetNumberOfThreads();
            }
        }
        public int GetNumberOfThreads()
        {
            if (HyperT == true) return (Core * 2);
            else return (Core);
        }
    }
}
