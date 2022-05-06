using UnityEngine;
namespace Figuras
{
    public class FigurasFactory :  MonoBehaviour
    {
        [SerializeField] private FigurasGeometricas _Cubofactory;

        [SerializeField] private FigurasGeometricas _Cilindrofactory;

        [SerializeField] private FigurasGeometricas _Esferafactory;
        public FigurasGeometricas Create(string id)
        {
            switch (id)
            {
                case "cubo":
                    
                    return Instantiate(_Cubofactory);
                case "cilindro":

                    return Instantiate(_Cilindrofactory);
                case "esfera":

                    return Instantiate(_Esferafactory);
                default:
                    return null;

            }

        }
    }
}
