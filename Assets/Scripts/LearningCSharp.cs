using JetBrains.Annotations;
using System.Collections;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Assets.Scripts
{
    public class LearningCSharp : MonoBehaviour
    {
        public int n;
        private void Update()
        {
            CompareEvenOdd(n);
        }
        public void CompareEvenOdd(int n)
        {
            int Even = 0;
            int Odd = 0;
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Random.Range(1,6);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Even += numbers[i];
                }
                else
                {
                    Odd += numbers[i];
                }
            }
            //Debug.Log($"tong cac so chan la : {Even}");
            //Debug.Log($"tong cac so le la : {Odd}");
            if (Even > Odd)
            {
                Debug.Log($"tong cac so chan > tong cac so le ");
            }
            else if (Even == Odd)
            {
                Debug.Log($"tong cac so chan = tong cac so le ");
            }
            else
            {
                Debug.Log($"tong cac so chan < tong cac so le ");
            }
        }
    }
}