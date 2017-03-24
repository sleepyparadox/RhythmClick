using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace RhythmClick.RythmClick.Unity.Assets.Code.Entity
{
    public interface IEntity
    {
        void NoteRayHit(NoteRay ray);
    }
}
