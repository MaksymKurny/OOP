using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_5a
{
    public class CPU {
        public string Number { get; set; }
        public string Segment { get; set; }
        public int Core { get; set; }
        public int Year { get; set; }
        public double BFrequency { get; set; }
        public double TFrequency { get; set; }
        public bool HyperT { get; set; }
        public int GetNumberOfThreads() {
            if (HyperT) return (Core * 2);
            else return (Core);
        }
        public CPU(){ }
        public CPU(string number, string segment, int core,
        int year, double bFrequency, double tFrequency, bool hyperT) {
            Number = number;
            Segment = segment;
            Core = core;
            Year = year;
            BFrequency = bFrequency;
            TFrequency = tFrequency;
            HyperT = hyperT;
        }
    }
}