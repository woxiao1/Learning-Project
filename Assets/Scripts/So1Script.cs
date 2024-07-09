using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Scripts
{
    public class So1Script : MonoBehaviour
    {

        public float a, b, c;

        void Start()
        {
            float delta, x1, x2;

            delta = b * b - 4 * a * c;

            if (delta > 0)
            {

                x1 = ((float)(-b + Math.Sqrt(delta))) / (2 * a);
                x2 = ((float)(-b - Math.Sqrt(delta))) / (2 * a);

                Debug.Log($"Phương trình có 2 nghiệm : {x1}, {x2}");
            }

            else if (delta == 0)
            {

                x1 = x2 = -b / (2 * a);

                Debug.Log($"Phương trình có nghiệm kép : {x1}");

            }

            else
            {
                Debug.Log("Phương trình vô nghiệm");
            }

        }
    }
}