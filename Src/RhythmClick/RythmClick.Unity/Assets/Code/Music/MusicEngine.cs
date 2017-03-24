using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace RhythmClick.RythmClick.Unity.Assets.Code
{
    public static class MusicEngine
    {
        static Dictionary<Note, AudioClip> _clips;
        static AudioSource _source;

        public static void Init()
        {
            _clips = new Dictionary<Note, AudioClip>();

            var emitterObj = new UnityObject("MusicEngine");
            emitterObj.u.Update += Tick;
            _source = emitterObj.GameObject.AddComponent<AudioSource>();
        }

        public static void Load(IEnumerable<Note> notes)
        {
            foreach (var note in notes)
            {
                if (_clips.ContainsKey(note))
                    continue;

                var clip = AssetManager.Load<AudioClip>("Resources/Pluck4/" + note.ToString());
                if (clip == null)
                    throw new Exception(note + " not found!");

                _clips.Add(note, clip);
            }
        }

        public static void Play(Note note)
        {
            var clip = _clips[note];
            _source.PlayOneShot(clip);
        }

        static void Tick(UnityObject u)
        {

        }
    }
}
