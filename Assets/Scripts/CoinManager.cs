using System.Collections;
using Unity.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class CoinManager : MonoBehaviour
    {
        public GameObject CoinPrefab;
        public Transform CoinManagerTransform;
        public float startTime = 0;
        public float spawnTime = 0.5f;

        private void Update()
        {
            startTime -= Time.deltaTime;
            if (startTime <=0)
            {
                CoinSpawn();
                startTime = spawnTime;
            }
        }
        private void CoinSpawn()
        {
            var randomX = Random.Range(-5f, 5f);
            var randomZ = Random.Range(-5f, 5f);
            Vector3 newPosition = new Vector3(randomX, CoinManagerTransform.position.y, randomZ);
            GameObject newCoin = Instantiate(CoinPrefab);
            newCoin.transform.position = newPosition;
        }
    }



}
