using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaasCommand
{
    class qParse
    {
        public string parse(string msg)
        {
            Console.WriteLine("Start Parse");
            Console.WriteLine("Input string: " + msg);
            string nospace = String.Concat(msg.Where(c => !Char.IsWhiteSpace(c)));
            Console.WriteLine("Nospace: " + nospace);
            string[] elements = nospace.Split(',');
            Console.WriteLine(elements);

            switch (elements[0]) {

                case "SERIALNUMBER":
                    Console.WriteLine("Parsing Serial Number");
                    return elements[1];
                    

                case "SOFTWAREVERSION":
                    Console.WriteLine("Parsing Software Version");
                    return elements[1];
                    

                case "MODEL":
                    Console.WriteLine("Parsing Model");
                    return elements[1];
                    

                case "TOOLCHANGES":
                    Console.WriteLine("Parsing Total Tool Changes");
                    return elements[1];

                case "MACRO":
                    Console.WriteLine("Parsing Macro Var");
                    return elements[1];


                default:
                    Console.WriteLine("ERROR: Invalid response");
                    return "";
            }

            
        }

        public int m_toolLengthStart = 2001;
        public int m_toolLengthEnd = 2200;

        public int m_toolDiameterStart = 2401;
        public int m_toolDiameterEnd = 2600;

        public int m_toolCoolantStart = 3401;
        public int m_toolCoolantEnd = 3600;






    }
}
