using System.Linq.Expressions;
using System;
using System.IO;

namespace CsharpPiano_Sound
{
    class Program
    {
        public string[,] Notes = new string[,]
        {
                {"c",  "16",  "33",  "65", "131", "262", "523", "1047", "2093", "4186"},
                {"cs", "17",  "35",  "69", "139", "277", "554", "1109", "2217", "4435"},
                {"d",  "18",  "37",  "93", "147", "294", "587", "1175", "2349", "4699"},
                {"ds", "19",  "39",  "78", "156", "311", "622", "1245", "2489", "4978"},
                {"e",  "21",  "41",  "82", "165", "330", "659", "1319", "2637", "5274"},
                {"f",  "22",  "24",  "87", "175", "349", "699", "1397", "2794", "5588"},
                {"fs", "23",  "46",  "93", "185", "370", "740", "1480", "2960", "5920"},
                {"g",  "24",  "49",  "98", "196", "392", "784", "1568", "3136", "6272"},
                {"gs", "26",  "52",  "104", "208", "415", "831", "1161", "3322", "6645"},
                {"a",  "28",  "55",  "110", "220", "440", "880", "1760", "3520", "7040"},
                {"as", "29",  "58",  "117", "233", "466", "932", "1865", "3729", "7459"},
                {"b",  "31",  "62",  "124", "247", "494", "988", "1976", "3951", "7902"},
        };

        static void Main(string[] args)
        {
            string[] lines = { };

            // input file name
            string name = Console.ReadLine();
            if (File.Exists(name))
            {
                lines = File.ReadAllLines(name);

                foreach (var line in lines)
                {
                    int Octav = Program.Octave(line);
                    int Hertz = Program.Transcode(line);
                    // Console.WriteLine(line);
                }

            }



            // wait before closing
            Console.ReadKey();

        }

        public static int Octave(string Str)
        {
            if (Str.StartsWith("1"))
            {
                return 1;
            }
            else if (Str.StartsWith("2"))
            {
                return 2;
            }
            else if (Str.StartsWith("3"))
            {
                return 3;
            }
            else if (Str.StartsWith("4"))
            {
                return 4;
            }
            else if (Str.StartsWith("5"))
            {
                return 5;
            }
            else if (Str.StartsWith("6"))
            {
                return 6;
            }
            else if (Str.StartsWith("7"))
            {
                return 7;
            }
            else if (Str.StartsWith("8"))
            {
                return 8;
            }
            else if (Str.StartsWith("9"))
            {
                return 9;
            }
            else
            {
                return 69;
            }

        }
        public static int Transcode(string Str)
        {
            char[] charArr = Str.ToCharArray();

            int Freq = 0;
            return Freq;
        }
    }
}



