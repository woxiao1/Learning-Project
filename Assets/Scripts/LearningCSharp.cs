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
        //min    6                 <             unsort     3
        //sort  1   5

        private void Start()
        {
            //int[] randomIntArray = GetRandomIntArray(ArrayLength, 1, 2000);

            //Debug.Log("Before Sort");
            //PrintArray(randomIntArray);
            //int[] sortedArray = Sort(randomIntArray);
            //Debug.Log("After Sort");
            //PrintArray(sortedArray);
            //int index = BinarySearch(sortedArray, 250);
            //if(index != -1)
            //{
            //    Debug.Log($"Find at index {index}");
            //}

            int[] sortedArray = new int[]
            {
                11,19,30,33,40,51
            };

            int result = BinarySearchVersion2(sortedArray, 19);
            Debug.Log(result);

            int result2 = BinarySearchVersion2(sortedArray, 30);
            Debug.Log(result2);
        }

        public void CallMe(int callTime)
        {
            if (callTime <= 0)
            {
                return;
            }

            Debug.Log($"Before Recursive Call {callTime}");

            CallMe(callTime - 1);

            Debug.Log($"After Recursive Call {callTime}");
        }

        // neu sortedArray.Length == 1 &&  return -1;
        // cat doi
        // -> coi vi tri o giua co` phai la numberToFind => tra ve numberToFind
        // so sanh, neu vi tri giua > numberToFind -> BinarySearch ben trai
        //  neu vi tri giua < numberToFind -> BinarySearch ben phai
        public int BinarySearchVersion2(int[] sortedArray, int numberToFind)
        {
            return BinarySearchVersion2_Helper(sortedArray, 0, sortedArray.Length - 1, numberToFind);
        }

        //11,19,30,33,40,51
        public int BinarySearchVersion2_Helper(int[] sortedArray, int start, int end, int numberToFind)
        {
            // start 3 , end 5
            if (sortedArray.Length == 0)
            {
                return -1;
            }

            if (sortedArray.Length == 1)
            {
                return sortedArray[0] == numberToFind ? 0 : -1;
            }

            int currentCount = end - start + 1;
            if(currentCount <= 0)
            {
                return -1;
            }

            int mid = ((end - start) / 2) + start; //( 5 - 3) /2
            int midValue = sortedArray[mid];

            if (midValue == numberToFind)
            {
                return mid;
            }
            else if (midValue > numberToFind)
            {
                return BinarySearchVersion2_Helper(sortedArray, start, mid - 1, numberToFind);
            }
            else
            {
                return BinarySearchVersion2_Helper(sortedArray, mid + 1, end, numberToFind);
            }
        }

        public int BinarySearch(int[] sortedArray, int numberToFind)
        {
            if (sortedArray.Length == 0)
            {
                return -1;
            }

            if (sortedArray.Length == 1)
            {
                if (sortedArray[0] == numberToFind)
                {
                    return numberToFind;
                }
                else
                {
                    return -1;
                }
            }

            int mid = sortedArray.Length / 2;
            int midValue = sortedArray[mid];

            if (midValue == numberToFind)
            {
                return numberToFind;
            }
            else if (midValue > numberToFind)
            {
                // 1 2 5 8 9 
                // midValue 5
                // mid 2

                // chon ben trai
                int start = 0;
                int end = mid - 1;

                int count = mid - start;
                int[] leftArray = new int[count];

                for (int i = start; i <= end; i++)
                {
                    leftArray[i] = sortedArray[i];
                }

                int leftResult =  BinarySearch(leftArray, numberToFind);
                return leftResult;
            }
            else
            {
                // 3 -> 4
                // 1 2 5 8 9 
                // midValue 5
                // mid 2

                // chon ben trai
                int start = mid + 1;
                int end = sortedArray.Length - 1;

                int count = end - mid;
                int[] rightArray = new int[count]; // []  []

                int counter = 0;
                for (int i = start; i <= end; i++)
                {
                    rightArray[counter] = sortedArray[i];
                    counter++;
                }

                return BinarySearch(rightArray, numberToFind);
            }
        }

        public int[] Sort(int[] unsortedArray) // sum 1 -> n, n^2
        {
            for (int i = 0; i < unsortedArray.Length; i++ )
            {   
                for (int j = i; j < unsortedArray.Length; j++)
                {
                    if (unsortedArray[i] > unsortedArray[j] )
                    {
                        int temp = 0;
                        temp = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[j];
                        unsortedArray[j] = temp;
                    }                   
                }
            }

            return unsortedArray;
        }

        public int FindMin(int[] randomIntArray)    // O(n)
        {
            int minValue = int.MaxValue;
            for (int i = 0; i < randomIntArray.Length; i++)
            {
                int a = randomIntArray[i];
                if (a < minValue)
                {
                    minValue = a;
                }
            }
            return minValue;
        }

        public void FindMinMax(int[] randomIntArray) // O (n)
        {
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            for (int i = 0; i < randomIntArray.Length; i++) 
            {
                int a = randomIntArray[i];
                if (a < minValue)
                {
                    minValue = a;
                }

                if (a > maxValue)
                {
                    maxValue = a;
                }
            }
            Debug.Log(minValue);
        }

        public bool CheckSquareRoot(int number)
        {
            for (int i = 1; i < number/2; i++) // n /2 , n
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
                //Debug.Log(numbers[i]);
            }

            return numbers;
        }

        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Debug.Log(array[i]);
            }
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