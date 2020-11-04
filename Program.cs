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
            string temp = Console.ReadLine();
            string name = temp + ".txt";
            if (File.Exists(name))
            {
                lines = File.ReadAllLines(name);


                foreach (var line in lines)
                {
                    string temp_line = "";
                    if (line == "")
                    {

                    }
                    char Octav = Program.Octave(line);


                    temp_line = line.Trim(Octav);
                    string line2 = temp_line;
                    temp_line = line2.Trim(Convert.ToChar("|"));
                    Console.WriteLine(temp_line);
                    // char[] line_temp = line.ToCharArray();

                    // for (var i = 0; line_temp.Length > i; i++)
                    // {
                    //     Console.WriteLine(line_temp[i]);
                    // }
                    // Array.Clear(line_temp, 0, 26);
                    // int Hertz = Program.Transcode(line_temp);
                    // Console.WriteLine(line);
                }

            }


            // File.OpenWrite(temp + "_transcoded.txt");
            string pad = temp + "_transcoded.txt";
            File.WriteAllLines(pad, lines);
            // wait before closing
            Console.ReadKey();

        }

        public static char Octave(string Str)
        {
            if (Str.StartsWith("1"))
            {
                return Convert.ToChar("1");
            }
            else if (Str.StartsWith("2"))
            {
                return Convert.ToChar("2");
            }
            else if (Str.StartsWith("3"))
            {
                return Convert.ToChar("3");
            }
            else if (Str.StartsWith("4"))
            {
                return Convert.ToChar("4");
            }
            else if (Str.StartsWith("5"))
            {
                return Convert.ToChar("5");
            }
            else if (Str.StartsWith("6"))
            {
                return Convert.ToChar("6");
            }
            else if (Str.StartsWith("7"))
            {
                return Convert.ToChar("7");
            }
            else if (Str.StartsWith("8"))
            {
                return Convert.ToChar("8");
            }
            else if (Str.StartsWith("9"))
            {
                return Convert.ToChar("9");
            }
            else
            {
                return Convert.ToChar("`");
            }

        }
        public static int Transcode(string Str)
        {
            char[] charArr = Str.ToCharArray();
            for (var i = 0; i < charArr.Length; i++)
            {
                // Console.WriteLine(charArr[i]);
            }

            int Freq = 0;
            return Freq;
        }
    }
}



