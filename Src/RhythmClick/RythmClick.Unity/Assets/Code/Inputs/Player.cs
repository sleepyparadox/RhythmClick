using RhythmClick.RythmClick.Unity.Assets.Code;
using RhythmClick.RythmClick.Unity.Assets.Code.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace RhythmClick.RythmClick.Unity.Assets.Code.Inputs
{
    public class Player : UnityObject
    {
        const float Speed = 10f;
        const float JumpForce = 300f;
        const float RotateSpeed = 360f;
        private Rigidbody _rigid;

        public Player(GameObject sceneObject) : base(sceneObject)
        {
            _rigid = GameObject.GetComponent<Rigidbody>();
            var musicInput = new MusicInput();
            u.Update += o => musicInput.Step();
            u.Update += Update;
        }

        void Update(UnityObject uObj)
        {
            WorldPosition += Transform.forward * Input.GetAxis("Vertical") * Speed * Time.deltaTime;
            WorldPosition += Transform.right * Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

            Transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * RotateSpeed * Time.deltaTime, Space.Self);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigid.AddForce(Vector3.up * JumpForce);
            }
        }
    }
}
