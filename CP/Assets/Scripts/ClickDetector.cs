using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Figuras {

    public class ClickDetector : MonoBehaviour
    {
        private int valorColor=0;
        void Update()
        {
            OnButtonClicked();
            switch (valorColor)
            {
                case 0:
                    gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                    break;
                case 1:
                    gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                    break;
                case 2:
                    gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    break;
                case 3:
                    gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                    break;
                default:
                    gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                    break;
            }
        }
        void OnButtonClicked()
        {
            if (Input.GetMouseButtonDown(0))
            {

                if (valorColor == 3)
                {
                    valorColor = 0;
                }
                else
                {
                    valorColor++;
                }
                Debug.Log(valorColor);

            }
        }
    }
}

