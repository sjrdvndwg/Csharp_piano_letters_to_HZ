﻿using System.Linq.Expressions;
using System;
using System.IO;

namespace CsharpPiano_Sound
{
    class Program
    {
        public void Variables()
        {
            public zstring[] lines = { };
        public int PIN = 13;
        public int pauze = 100;
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

        public int C = 0;
        public int CS = 1;
        public int D = 2;
        public int DS = 3;
        public int E = 4;
        public int F = 5;
        public int FS = 6;
        public int G = 7;
        public int GS = 8;
        public int A = 9;
        public int AS = 10;
        public int B = 11;
        public int db = 1;
        public int eb = 3;
        public int gb = 6;
        public int ab = 8;
        public int bb = 10;

    }

    static void Main(string[] args)
    {


        // input file name
        string name = Console.ReadLine();
        if (File.Exists(name))
        {
            lines = File.ReadAllLines(name);

        }

        // for (int i = 0; i < 11; i++)
        // {
        //     for (int j = 0; j < 9; j++)
        //     {

        //         Console.WriteLine(i + "," + j + ":" + Notes[i, j]);

        //     }
        // }
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
            Transcode(lines[i]);
        }
        Console.ReadKey();


    }

    public int Transcode(string str)
    {
        Notes[0, 5];

        int sendback = 0;
        // sendback =;
        return sendback;
    }
}
}

