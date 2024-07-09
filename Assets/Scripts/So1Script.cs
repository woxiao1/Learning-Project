using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Scripts
{
    public class So1Script : MonoBehaviour
    {
        public float a;
        public float b;
        public float c;

        void Start()
        { 
            float delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Debug.Log($"Phương trình có 2 nghiệm : {x1}, {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Debug.Log($"Phương trình có nghiệm kép : {x}");
            }
            else
            {
                Debug.Log("Phương trình vô nghiệm");
            }
        }
    }
}