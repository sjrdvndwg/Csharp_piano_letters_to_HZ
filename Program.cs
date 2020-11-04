using System.Linq.Expressions;
using System.Collections.Generic;
using System;
using System.IO;

namespace CsharpPiano_Sound
{

    public static class Extensions
    {
        public static T[] Append<T>(this T[] array, T item)
        {
            return new List<T>(array) { item }.ToArray();
        }
    }
    class Program
    {
        public static int time = 100;
        public static string[,] Notes = new string[,]
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
            int[] note = { };


            // input file name
            string temp = Console.ReadLine();
            string name = temp + ".txt";
            File.OpenWrite(temp + "_transcoded.txt");
            if (File.Exists(name))
            {
                lines = File.ReadAllLines(name);


                foreach (var line in lines)
                {
                    string temp_line = "";
                    if (line == "END")
                    {
                        Console.WriteLine("END");
                    }
                    char Octav = Program.Octave(line);
                    int octaaf = Convert.ToInt32(Octav);

                    temp_line = line.Trim(Octav);
                    string line2 = temp_line;
                    temp_line = line2.Trim(Convert.ToChar("|"));
                    // Console.WriteLine(temp_line);

                    char Hertz = Program.Transcode(temp_line);
                    int Freq;
                    if (Convert.ToString(Hertz).ToLower() == "a")
                    {
                        Freq = Convert.ToInt32(Notes[9, (octaaf + 1)]);
                        Finalize(Freq, Program.time);

                    }
                    else if (Convert.ToString(Hertz).ToLower() == "b")
                    {
                        Freq = Convert.ToInt32(Notes[11, (octaaf + 1)]);
                        Finalize(Freq, Program.time);

                    }
                    else if (Convert.ToString(Hertz).ToLower() == "c")
                    {
                        Freq = Convert.ToInt32(Notes[0, (octaaf + 1)]);
                        Finalize(Freq, Program.time);

                    }
                    else if (Convert.ToString(Hertz).ToLower() == "d")
                    {
                        Freq = Convert.ToInt32(Notes[2, (octaaf + 1)]);
                        Finalize(Freq, Program.time);

                    }
                    else if (Convert.ToString(Hertz).ToLower() == "e")
                    {
                        Freq = Convert.ToInt32(Notes[4, (octaaf + 1)]);
                        Finalize(Freq, Program.time);

                    }
                    else if (Convert.ToString(Hertz).ToLower() == "f")
                    {
                        Freq = Convert.ToInt32(Notes[5, (octaaf + 1)]);
                        Finalize(Freq, Program.time);

                    }
                    else if (Convert.ToString(Hertz).ToLower() == "g")
                    {
                        Freq = Convert.ToInt32(Notes[7, (octaaf + 1)]);
                        Finalize(Freq, Program.time);

                    }




                }

            }



            string pad = temp + "_transcoded.txt";

            // Console.WriteLine(Program.Notes[1, 2]);
            // File.WriteAllLines(pad, note);
            // wait before closing
            Console.ReadKey();

        }

        public static void Finalize(int Frequentie, int Duration)
        {
            // TODO finish file writing capabilities and transfer the file name
            Console.WriteLine(Frequentie + time);

            // File.AppendAllLines("");
        }
        public static char Octave(string Str) //finished for now
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
        public static char Transcode(string Str)
        {
            // TODO make it useful and actually do shit

            char Freq = Convert.ToChar("i");
            char[] charArr = Str.ToCharArray();
            for (var i = 0; i < charArr.Length; i++)
            {

            }


            return Freq;
        }
    }
}



