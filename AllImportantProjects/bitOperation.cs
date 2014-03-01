using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllImportantProjects
{
    class bitOperation
    {
        public Byte swapBits(Byte x, Byte i, Byte j) 
        {
            
            Byte lo = (Byte)((Byte)(x >> i) & 1);  
            Byte hi = (Byte)((Byte)(x >> j) & 1);  
            if ((lo ^ hi) == 1)
            {    
                x ^= (Byte)((1 << i) | (1<< j));  
            }  
            return x;
        } 
        
        public Byte Reverse(Byte x) 
        {  
            Byte n = sizeof(Byte) * 8;  
            for (Byte i = 0; i < n/2; i++) 
            {   
                x = swapBits(x, i, (Byte)(n-i-1));  
            }  
            return x;
        }

        public Byte ReverseNoBit(Byte x)
        {
            byte sum = 0;
            while (x > 0)
            {
                Byte digit = (Byte)(x % 2);
                sum = (Byte)(sum * 2 + digit);
                x = (Byte)(x / 2);
            }
            return sum;

        }

    }
}
