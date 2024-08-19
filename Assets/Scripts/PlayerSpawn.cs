using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerSpawn : MonoBehaviour
    {
        public Transform SpawnPoint;
        public Transform PlayerTransform;

        private void Start()
        {
            Spawn();
        }

        private void Spawn()
        {
            PlayerTransform.position = SpawnPoint.position;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Finish")
            {
                Debug.Log("Win");
            }
        }
    }
}