using RhythmClick.RythmClick.Unity.Assets.Code.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace RhythmClick.RythmClick.Unity.Assets.Code
{
    public class Game : MonoBehaviour
    {
        void Awake()
        {
            new Player(gameObject);
        }
    }
}
