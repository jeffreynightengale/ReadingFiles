using System;
using System.Collections.Generic;
using System.IO;

namespace ReadingInFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("geoMap.csv");
            List<string> states = new List<string>();
            List<double> soccerScores = new List<double>();
            List<double> footballScores = new List<double>();


            for (int i = 3; i < lines.Length; i++)
            {
                //"Alabama,16%,84%"
                string line = lines[i];

                //
                //{"Alabama","16%","84%"}
                string[] pieces = line.Split(',');
                string state = pieces[0];
                states.Add(state);

                string soccerScoreString = pieces[1].Remove(pieces[1].Length-1); //Will have to do on finals
                double soccerScore = Convert.ToDouble(soccerScoreString) / 100;
                soccerScores.Add(soccerScore);


                footballScores.Add(Convert.ToDouble(pieces[2].Remove(pieces[1].Length-1)) / 100);
                //Console.WriteLine(state); //use this line and above line to just get states
                //Console.WriteLine(line);
            }

            for (int i = 0; i < states.Count; i++)
            {
                string state = states[i];
                double soccer = soccerScores[i];
                double football = footballScores[i];

                if (soccer > football)
                {
                    Console.WriteLine(state);
                }
            }

        }
    }
}
