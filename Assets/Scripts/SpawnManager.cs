using System.Collections;
using Unity.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject CoinPrefab;
        public GameObject ObstaclePrefab;
        public Transform CoinManagerTransform;
        public float startTime = 0;
        public float spawnTime = 0.5f;
        public float Percent;

        public bool IsPlaying = true;
        
        private void Update()
        {
            if (IsPlaying)
            {
                HandleSpawn();
            }
        }

        public void StopSpawn()
        {
            IsPlaying = false;
        }

        private void HandleSpawn()
        {
            startTime -= Time.deltaTime;
            if (startTime <= 0)
            {
                Spawn();
                startTime = spawnTime;
            }
        }

        private void Spawn()
        {
            float randomX = Random.Range(-5f, 5f);
            float randomZ = Random.Range(-5f, 5f);
            float randomPercent = Random.Range(0f, 1f);
            Vector3 newPosition = new Vector3(randomX, CoinManagerTransform.position.y, randomZ);
            if (randomPercent <= Percent)
            {
                GameObject newSpawn = Instantiate(CoinPrefab);
                newSpawn.transform.position = newPosition;
            }
            else
            {
                GameObject newSpawn = Instantiate(ObstaclePrefab);
                newSpawn.transform.position = newPosition;
            }
        }
    }
}
