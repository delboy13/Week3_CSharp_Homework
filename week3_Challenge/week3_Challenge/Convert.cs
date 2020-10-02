using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_Challenge
{
    class Convert
    {
        public void Conversion(int number)
        {
            string hundreds = "";
            string tens = "";
            string units = "";

            switch (number / 100)
            {
                case 1: hundreds = "One Hundred"; break;
                case 2: hundreds = "Two Hundred"; break;
                case 3: hundreds = "Three Hundred"; break;
                case 4: hundreds = "Four Hundred"; break;
                case 5: hundreds = "Five Hundred"; break;
                case 6: hundreds = "Six Hundred"; break;
                case 7: hundreds = "Seven Hundred"; break;
                case 8: hundreds = "Eight Hundred"; break;
                case 9: hundreds = "Nine Hundred"; break;
            }

            switch ((number % 100) / 10)
            {
                case 1: tens = "Ten"; break;
                case 2: tens = "Twenty"; break;
                case 3: tens = "Thirty"; break;
                case 4: tens = "Fourty"; break;
                case 5: tens = "Fifty"; break;
                case 6: tens = "Sixty"; break;
                case 7: tens = "Seventy"; break;
                case 8: tens = "Eighty"; break;
                case 9: tens = "Ninety"; break;
            }

            if ((number % 100) / 10 != 1)
            {
                switch ((number % 100) % 10)
                {
                    case 1: units = "one"; break;
                    case 2: units = "Two"; break;
                    case 3: units = "Three"; break;
                    case 4: units = "Four"; break;
                    case 5: units = "Five"; break;
                    case 6: units = "Six"; break;
                    case 7: units = "Seven"; break;
                    case 8: units = "Eight"; break;
                    case 9: units = "Nine"; break;
                }
            }
            else
            {
                switch (number % 100)
                {
                    case 1: tens = "Eleven"; break;
                    case 2: tens = "Twelve"; break;
                    case 3: tens = "Thirteen"; break;
                    case 4: tens = "Fourteen"; break;
                    case 5: tens = "Fifteen"; break;
                    case 6: tens = "Sixteen"; break;
                    case 7: tens = "Seventeen"; break;
                    case 8: tens = "Eighteen"; break;
                    case 9: tens = "Nineteen"; break;
                }
            }
            Console.WriteLine(hundreds + " " + tens + " " + units);
        }

    }
}
    