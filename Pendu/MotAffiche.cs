using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu
{
    class printWord
    {
        private String word;
        private Char[] printArray;


        public printWord(String s)
        {
            printArray = new Char[2 * s.Length];
            for (int i = 0; i < 2 * s.Length; i = i + 2)
            {
                printArray[i] = '_';
                if (i < 2*s.Length)
                {
                    printArray[i + 1] = ' ';
                }
            }
            word = new string(printArray);
        }

        public String getWord()
        {
            return word;
        }

        public Boolean testLetter(Char[] tabSecret, Char c)
        {
            Boolean winner = false;

            for (int j = 0; j < tabSecret.Length; j++)
            {
                if (c.Equals(tabSecret[j]))
                {
                    if (j == 0)
                    {
                        printArray[0] = tabSecret[j];
                    }

                    else
                    {
                        printArray[2 * j] = tabSecret[j];
                    }
                    winner = true;
                    word = new string(printArray);
                }
            }

            return winner;
        }

        public Boolean testWord(Char[] tabSecret)
        {
            for(int i=0; i<tabSecret.Length; i++)
            {
                if (tabSecret[i] != printArray[2 * i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
