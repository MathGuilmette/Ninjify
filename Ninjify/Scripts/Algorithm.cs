using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Ninjify.Scripts
{
    public class Algorithm
    {
        string[] ninjaTable;

        public Algorithm()
        {
            //READ FILES AND INITIALIZE

            var lines = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "/Files/TechnologyBuzzwords.txt");
            //var lines = File.ReadLines("C:/Users/MathGuilmette/Desktop/Ninjify/Ninjify/Files/TechnologyBuzzwords.txt");
            ninjaTable = new string[lines.Count()];
            for (var i = 0; i < lines.Count(); i++)
            {
                ninjaTable[i] = lines.ElementAt(i);
                
                /*for (int i = 0; i < 100; i++)
                {
                    ninjaTable[i] = i.ToString();
                }*/
            }
        }

        //PUBLIC WHOLE TRANSFORMATION
        public string WordToNinja(string input)
        {
            string resultName = "";
            if (input == "")
            {
                resultName = "...Oh you ! It's an empty input :/";
            }
            else
            {
                string[] inputsTable = input.Split(',');
                
                for (int i = 0; i < inputsTable.Length; i++)
                {
                    resultName += NinjaName(WordValue(inputsTable[i])) + " ";
                }
            }

            return resultName;

        }

        //TRANFORM WORD INTO A NUMBER
        private int WordValue(string word)
        {
            int value = 0;
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(word.ToUpper());

            foreach(char c in ASCIIValues)
            {
                value += c;
            }

            return value;
        }

        //GET NINJANAME FROM WORD VALUE
        private string NinjaName (int value)
        {
            int index = value % ninjaTable.Length; //MODULO <3 <3

            return ninjaTable[index];
        }


    }
}