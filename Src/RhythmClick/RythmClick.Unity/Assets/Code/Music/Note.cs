using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RhythmClick.RythmClick.Unity.Assets.Code
{
    public struct Note
    {
        public int Value;

        public Letter Letter { get { return (Letter)(Value % (int)Letter.LENGTH); } }
        public int Octave { get { return Value / (int)Letter.LENGTH;  } }

        public Note(Letter letter, int octave = 4)
        {
            Value = (octave * (int)Letter.LENGTH) + (int)letter;
        }

        public Note(int value)
        {
            Value = value;
        }

        // Chords
        public Note GetCordNth(int n)
        {
            // 1st is chord value
            // 2nd is chord value + 1 ect..
            return new Note(Value + n - 1);
        }

        public override string ToString()
        {
            return Letter.ToString().ToLower() + Octave.ToString();
        }
    }

    public enum Letter
    {
        C,
        D,
        E,
        F,
        G,
        A,
        B,
        LENGTH
    }
}
