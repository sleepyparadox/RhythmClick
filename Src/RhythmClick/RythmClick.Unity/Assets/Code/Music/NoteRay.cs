using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace RhythmClick.RythmClick.Unity.Assets.Code
{
    public struct NoteRay
    {
        public RaycastHit Hit;
        public Ray Ray;
        public NoteType NoteType;
        public Note[] Notes;
    }
}
