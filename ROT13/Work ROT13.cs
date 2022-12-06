using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROT13
{
    public class Work_ROT13
    {
        public void WordEncryption(string enter)
        {
            char[] latinAlphabetLowercase = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] latinAlphabetUppercase = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            var enterchars= enter.ToArray();
            for(int i = 0; i < enterchars.Length; i++)
            {
                if (char.IsLetter(enterchars[i]))
                {
                    bool checkEnglish=false;
                    foreach (char c in latinAlphabetLowercase)
                    {
                        if(enterchars[i]== c)
                        {
                            checkEnglish=true;
                        }
                    }
                    foreach(char c in latinAlphabetUppercase)
                    {
                        if (enterchars[i] == c)
                        {
                            checkEnglish = true;
                        }
                    }
                    if (checkEnglish)
                    {
                        char symbol = ' ';
                        int counter = 0;
                        bool checksymbol = false;
                        for (int j = 0; j < latinAlphabetLowercase.Length; j++)
                        {
                            if (enterchars[i] == latinAlphabetLowercase[j])
                            {
                                checksymbol = true;
                            }
                            if (checksymbol)
                            {
                                counter++;
                                if (counter == 13)
                                {
                                    symbol = latinAlphabetLowercase[j];
                                    counter = 0;
                                    checksymbol=false;
                                    break;
                                }
                            }
                            if (j == 25)
                            {
                                if (checksymbol == false)
                                {
                                    break;
                                }
                                j = 0;
                            }
                        }
                        for (int j = 0; j < latinAlphabetUppercase.Length; j++)
                        {
                            if (enterchars[i] == latinAlphabetUppercase[j])
                            {
                                checksymbol = true;
                            }
                            if (checksymbol)
                            {
                                counter++;
                                if (counter == 13)
                                {
                                    symbol = latinAlphabetUppercase[j];
                                    counter = 0;
                                    break;
                                }
                            }
                            if (j == 25)
                            {
                                if (checksymbol == false)
                                {
                                    break;
                                }
                                j = 0;
                            }
                        }
                        enterchars[i] = symbol;
                    }
                }
            }
            foreach(char c in enterchars)
            {
                Console.Write(c);
            }
        }

    }
}
