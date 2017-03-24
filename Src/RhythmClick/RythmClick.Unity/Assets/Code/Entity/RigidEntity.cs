using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace RhythmClick.RythmClick.Unity.Assets.Code.Entity
{
    public static class RigidEntity
    {
        const float ForcePerNote = 400f;
        const float ForcePerChord = ForcePerNote * 3f;

        public static void NoteRayHit(Rigidbody rigidbody, NoteRay ray)
        {
            Debug.Log("RigidEntity.NoteRayHit " + rigidbody.gameObject.name);
            Vector3 direction;

            if (ray.NoteType == NoteType.High)
                direction = Vector3.up;
            else if (ray.NoteType == NoteType.Low)
                direction = Vector3.down;
            else if (ray.NoteType == NoteType.Chord)
                direction = ray.Ray.direction.normalized;
            else
                throw new NotImplementedException();

            float force;
            if (ray.NoteType == NoteType.Chord)
                force = ForcePerChord;
            else
                force = ForcePerNote;

            rigidbody.AddForce(direction * ForcePerNote);
        }
    }
}
