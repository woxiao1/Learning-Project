using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerMovement : MonoBehaviour
    {
        public float Speed;

        void Update()
        {
            Vector3 direction = GetDirectionByAxis();
            Move(direction);
        }

        private Vector3 GetDirectionByAxis()
        {
            Vector3 direction = Vector3.zero;
            direction.z = Input.GetAxis("Vertical");// -1 , 0 , 1
            direction.x = Input.GetAxis("Horizontal");

            return direction;
        }
        
        private void Move(Vector3 direction)
        {
            direction = direction.normalized;
            transform.position += direction * Speed * Time.deltaTime;
        }
    }
}