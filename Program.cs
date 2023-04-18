using System;
using System.Collections.Generic;

namespace NumberToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the number between 1 and 3999: ");
            int s = int.Parse(Console.ReadLine());
            int tam = s.ToString().Length;

            if (s >= 1 && s <= 3999)
            {
                string number = intToRoman(s);
                Console.Write("The roman number is: " + number);
            }
            else
            {
                Console.WriteLine("The numeral must have between 1 and 3999");
            }

        }
        static public string intToRoman(int num)
        {
            string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] dozens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] thousands = { "", "M", "MM", "MMM" };

            string Roman = thousands[num / 1000] + hundreds[(num % 1000) / 100] + dozens[(num % 100) / 10] + units[num % 10];
            return Roman;
        }
/*        static public string IntToRoman(int number)
        {
            string[] roman = new string[12];
            bool haveLetter = false;
            int tam = number.ToString().Length;
            string st = number.ToString();
            Dictionary<int, string> numbersDic = new()
            {
                { 1, "I" },
                       { 4, "IV" },
                       { 5, "V" },
                       { 9, "IX" },
                       { 10, "X" },
                       { 40, "XL" },
                       { 50, "L" },
                       { 90, "XC" },
                       { 100, "C" },
                       { 400, "CD" },
                       { 500, "D" },
                       { 900, "CM" },
                       { 1000, "M" }
            };

            int nump = number;
            for (int i = 0; i < tam; i++)
            {

                int np = Convert.ToInt32(nump - nump % Math.Pow(10, tam - i - 1));
                int numberAct = np;
                haveLetter = numbersDic.TryGetValue(numberAct, out string num);

                if (haveLetter)
                //if (numbersDic[np] < numbersDic[num])
                {
                    roman[i] = num.ToString();
                }
                else
                {
                    for (int j = 0; j < tam; j++)
                    {
                        if (Convert.ToInt32(num) > nump)
                        {
                            haveLetter = numbersDic.TryGetValue(numberAct, out num);
                            if (haveLetter)
                            {
                                roman[i] = num.ToString();
                            }
                        }
                    }
                    haveLetter = numbersDic.TryGetValue(numberAct, out string numm);
                    
                }
                nump = Convert.ToInt32(nump % Math.Pow(10, tam - i - 1));
            }

            return roman.ToString();

        }
        /*       static public string Solution(int number)
               {
                   Dictionary<int, string> dict = new()
                   {
                       { 1, "I" },
                       { 4, "IV" },
                       { 5, "V" },
                       { 9, "IX" },
                       { 10, "X" },
                       { 40, "XL" },
                       { 50, "L" },
                       { 90, "XC" },
                       { 100, "C" },
                       { 400, "CD" },
                       { 500, "D" },
                       { 900, "CM" },
                       { 1000, "M" }
                   };
                   string intToRoman(int num)
                   {
                       string str = "";
                       List<int> list = new List<int> { 10, 100, 1000, 10000 };   //get the tens/hundreds/thousands place
                       foreach (int i in list)
                       {
                           if (num % i != 0)
                           {
                               str = (num % i, i / 10) + str;
                               num = num - (num % i);
                           }
                       }
                       return str;
                   }
        /*           string compute(Dictionary dict, int num, int lsb)
                   {
                       int np = Convert.ToInt32(nump - nump % Math.Pow(10, tam - i - 1));
                       int numberAct = np;
                       if (numbersDic.TryGetValue(numberAct, out char numm))
                       {
                           return dict[num];
                       }
                       else
                       {
                           return self.compute(num - lsb, lsb) + self.dict[lsb];
                       }
                   }
        */
 
    }
}


