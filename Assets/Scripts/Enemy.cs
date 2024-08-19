using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Enemy : MonoBehaviour
    {
        public Transform[] Path;
        public Transform EnemyTransform;
        public float Speed;


        private void Start()
        {
            Spawn();
        }

        private void Update()
        {
            // can tim huong di ke tiep
            Vector3 direction = Path[1].position - Path[0].position;

            Move(direction);
            //-----A-------B
            //------A------B

        }

        private void Spawn()
        {
            EnemyTransform.position = Path[0].position;
        }
        private void Move(Vector3 direction)
        {
            direction = direction.normalized;
            transform.position += direction * Speed * Time.deltaTime;
        }
    }
}