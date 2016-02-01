using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu
{
    class FindAWord
    {
        private String secret;
        private char[] secretArray;

        public FindAWord(String s)
        {
            secret = s;
            secretArray = s.ToCharArray();
        }

        public Char[] getSecretArray()
        {
            return secretArray;
        }


        public Boolean testTry(Char[] tryArray)
        {
            for (int i = 0; i < secretArray.Length; i++)
            {
                    if (secretArray[i] != tryArray[i])
                    {
                        return false;
                    }
                
            }
            return true;
        }
    }
}
