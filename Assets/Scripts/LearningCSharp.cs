using System.Collections;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Assets.Scripts
{
    public class LearningCSharp : MonoBehaviour
    {
        public int a = 0;
        public int b = 1;
        private void Start()
        {
            int previous = a;
            int current = b;
            int next = previous + current;
            Debug.Log(giaitoancanbac2cuaA(a));
            for (int i = 0; i <=100;i++)
            {
                Debug.Log(next);

            }
        }
        public int giaitoancanbac2cuaA(int a)
        {
            for (int i = 0; i < a/2; i++)
            {
                if (i * i == a )
                {
                    return i;
                }
            }
            return -1;
        }
    }
}