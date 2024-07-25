using JetBrains.Annotations;
using System.Collections;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Assets.Scripts
{
    public class LearningCSharp : MonoBehaviour
    {
        public int ArrayLength = 100;
        
        private void Start()
        {
            // CompareEvenOdd(n);

            int[] randomIntArray = GetRandomIntArray(ArrayLength, 1, 2000);

            for (int i = 0; i < randomIntArray.Length; i++)
            {
                // 0 -> 99
                int number = randomIntArray[i];
                bool hasSquareRoot = CheckSquareRoot(number);
                if (hasSquareRoot)
                {
                    Debug.Log($"So {number} co can bac 2");
                }
            }
        }

        public bool CheckSquareRoot(int number)
        {
            for (int i = 1; i < number/2; i++)
            {
                if (i * i == number)
                {
                    return true;
                }
            }

            return false;
        }

        public int[] GetRandomIntArray(int arrayLength,int randomMinValue,int randomMaxValue)
        {
            int[] numbers = new int[arrayLength];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Random.Range(randomMinValue,randomMaxValue);
            }

            return numbers;
        }
        
        public void CompareEvenOdd(int n) // 1000
        {
            int even = 0;
            int odd = 0;
            int[] numbers = GetRandomIntArray(n, -1000, 1000);
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even += numbers[i];
                }
                else
                {
                    odd += numbers[i];
                }
            }
            //Debug.Log($"tong cac so chan la : {Even}");
            //Debug.Log($"tong cac so le la : {Odd}");
            if (even > odd)
            {
                Debug.Log($"tong cac so chan > tong cac so le ");
            }
            else if (even == odd)
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