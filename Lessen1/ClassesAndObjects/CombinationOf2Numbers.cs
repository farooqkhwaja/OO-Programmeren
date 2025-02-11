using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class CombinationOf2Numbers
    {
        public int Number1;
        public int Number2;

        public double Sum()
        {
            return Number1 + Number2;
            
        } 
        public double Difference()
        {
            return Number1 - Number2;
            
        }
        public double Product()
        {
            return Number1 * Number2;
            
        } 
        public double Quotient()
        {
            if(Number2 != 0)
            {
                return Number1 / (double)Number2;
            }
            else
            {
                Console.WriteLine("Fout");
                return -1;
            }
            
        }
       
       

 


    }
}
