using RhythmClick.RythmClick.Unity.Assets.Code.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RhythmClick.RythmClick.Unity.Assets.Code.Inputs
{
    public class MusicInput
    {
        const float ChordInputBufferSecords = 0.05f;
        float?[] _mouseDownAt;
        Dictionary<NoteType, Note[]> _noteSets;

        public MusicInput()
        {
            _mouseDownAt = new float?[2];
            _noteSets = new Dictionary<NoteType, Note[]>()
            {
                { NoteType.Low, new Note[]
                    {
                        new Note(Letter.C),
                        new Note(Letter.D),
                        new Note(Letter.E),
                        new Note(Letter.F),
                    }
                },
                { NoteType.High, new Note[]
                    {
                        new Note(Letter.G),
                        new Note(Letter.A),
                        new Note(Letter.B),
                        new Note(Letter.C, 5),
                    }
                },
            };

            MusicEngine.Init();
            MusicEngine.Load(_noteSets.SelectMany(set => set.Value));
        }

        public void Step()
        {
            for (int i = 0; i < _mouseDownAt.Length; i++)
            {
                if (UnityEngine.Input.GetMouseButton(i))
                    _mouseDownAt[i] = Time.time;
            }

            if (_mouseDownAt.Any(m => m.HasValue && m + ChordInputBufferSecords < Time.time))
            {
                var input = NoteTypeFromMouseInputs(_mouseDownAt);

                Note[] notes;
                if (input == NoteType.Chord) // Both were pressed
                {
                    // todo random (currently use lowest)
                    var randomChord = new Note(Letter.C, 4);
                    notes = new[] { randomChord, randomChord.GetCordNth(2), randomChord.GetCordNth(5) };
                }
                else
                    notes = new[] { _noteSets[input].RandomItem() };

                foreach (var note in notes)
                    MusicEngine.Play(note);

                RaycastNotes(input, notes);

                // clear input
                for (int i = 0; i < _mouseDownAt.Length; i++)
                    _mouseDownAt[i] = null;
            }
        }



        static NoteType NoteTypeFromMouseInputs(float?[] mouseInputs)
        {
            if (mouseInputs.All(m => m.HasValue)) // Both were pressed
                return NoteType.Chord;
            else if (mouseInputs[0].HasValue)
                return NoteType.High;
            else if (mouseInputs[1].HasValue)
                return NoteType.Low;
            else
                throw new NotImplementedException();
        }

        void PlayRandomNote(Note[] notes)
        {
            var note = notes[UnityEngine.Random.Range(0, notes.Length)];
            MusicEngine.Play(note);
        }

        void RaycastNotes(NoteType noteType, Note[] notes)
        {
            var ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
            var hits = Physics.RaycastAll(ray);

            if (hits.Any())
            {
                var hit = hits.OrderBy(h => h.distance).First();

                var noteRay = new NoteRay()
                {
                    Hit = hit,
                    Ray = ray,
                    NoteType = noteType,
                    Notes = notes,
                };

                var target = hit.transform.gameObject;
                Debug.Log("RaycastNotes target " + target.name);
                foreach (var behaviour in target.GetComponentsInChildren<Component>())
                {
                    if (behaviour is IEntity)
                        (behaviour as IEntity).NoteRayHit(noteRay);
                    else if (behaviour is Rigidbody)
                        RigidEntity.NoteRayHit(behaviour as Rigidbody, noteRay);
                }
            }
        }
    }
}
