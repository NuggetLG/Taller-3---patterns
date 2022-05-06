using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Figuras
{


    public abstract class FigurasGeometricas : MonoBehaviour
    {
        [SerializeField] private string id;

        public string Id { get => id; set => id = value; }


    }
}
