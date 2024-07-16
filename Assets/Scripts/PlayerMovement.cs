using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerMovement : MonoBehaviour
    {
        public Transform PlayerTransform;
        public Transform TargetPosition;
        public float Speed;

        void Start()
        {
            Application.targetFrameRate = 120;
        }

        void Update()
        {
            Vector3 direction = GetDirectionByAxis();
            Move(direction);
        }

        private Vector3 GetDirectionByAxis()
        {
            Vector3 direction = Vector3.zero;
            direction.z = Input.GetAxisRaw("Vertical");// -1 , 0 , 1
            direction.x = Input.GetAxisRaw("Horizontal");

            return direction;
        }
        
        private Vector3 GetDirectionByKeyCode()
        {
            Vector3 direction = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
            {
                direction.z = 1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                direction.z = -1;
            }

            if (Input.GetKey(KeyCode.A))
            {
                direction.x = -1;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                direction.x = 1;
            }

            return direction;
        }

        private void Move(Vector3 direction)
        {
            direction = direction.normalized;
            PlayerTransform.position += direction * Speed * Time.deltaTime;
        }
    }
}