using System;
using System.Linq;
namespace PianoRoll
{
    public class Bah
    {
        public void GenerateAccord(string keysN, string lad) 
        {
            //int keysNN;
            //int fTerc;
            //int sTerc;
            var notes = new Dictionary<int, string>
            {
                {1, "C" },
                {2, "C#" },
                {3, "D" },
                {4, "D#" },
                {5, "E" },
                {6, "F" },
                {7, "F#" },
                {8, "G" },
                {9, "G#" },
                {10, "A" },
                {11, "A#" },
                {12, "B" }
            };
            var key = notes.FirstOrDefault(x => x.Value == keysN).Key;
            
            if (lad == "Major")
            {
                Console.WriteLine($"{notes[key]}\n{notes[(key + 4 - 1) % 12 + 1]}\n{notes[(key + 7 - 1) % 12 + 1]}");
            }
            else
            {
                Console.WriteLine($"{notes[key]}\n{notes[(key + 3 - 1) % 12 + 1]}\n{notes[(key + 7 - 1) % 12 + 1]}");
            }
        }
    }
}