using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CFG
    {
        String[] Code;
        char startNT;

        public CFG(String[] C)
        {
            Code = C;
        }

        public char getStartNT()
        {
            //Get the first non terminal in the code array
            String firstRule = Code[0];
            return firstRule[0];
        }

        public void setStartNT(char stNT)
        {
            startNT = stNT;
        }

        public bool processData(String inString, String wkString)
        {
            Console.WriteLine("Coming in: " + wkString);
            //Instring is the string we are looking for
            if (inString == wkString)
            {
                return true;
            }
            if (wkString.Length > inString.Length)
            {
                return false;
            }

            char selectedNT = ' ';
            int index = 0;
            for (int i = 0; i < wkString.Length; i++)
            {
                selectedNT = wkString[i];

                if (char.IsUpper(selectedNT))
                {
                    index = i;
                    Console.WriteLine("SelectedNT: " + selectedNT);
                    Console.WriteLine("Selected Index: " + index);
                    break;
                }
            }

            Boolean result = false;
            for (int i = 0; i < Code.Length; i++)
            {
                if (Code[i][0].Equals(selectedNT))
                {
                    string selectedRightSide = Code[i].Substring(3);

                    String copywkString = wkString.Remove(index,1);
                    Console.WriteLine("Removed: " + Code[i][0]);

                   
                    copywkString = copywkString.Insert(index, selectedRightSide);
                    Console.WriteLine("Changed String: " + wkString);

                    result = processData(inString, copywkString);
                    if(result == true)
                    {
                        break;

                    }
                }
            }
            return result;
            
            
        }




    }
}
