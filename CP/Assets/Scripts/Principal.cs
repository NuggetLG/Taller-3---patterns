using UnityEngine;
using UnityEngine.UI;
namespace Figuras
{
    public class Principal : MonoBehaviour
    {

        [SerializeField] private FigurasFactory _figurasFactory;
        public GameObject esfera;
        public GameObject cubo;
        public GameObject cilindro;
        public Button btnEsfera;
        public Button btnCubo;
        public Button btnCilindro;
        private string id;
      void Start()
        {
            esfera=GameObject.Find("Esfera");
            cubo = GameObject.Find("Cubo");
            cilindro = GameObject.Find("Cilindro");

           btnEsfera= esfera.GetComponent<Button>();
           btnEsfera.onClick.AddListener(getEstadoEsfera);
            btnCubo=cubo.GetComponent<Button>();
            btnCubo.onClick.AddListener(getEstadoCubo);
            btnCilindro = cilindro.GetComponent<Button>();
            btnCilindro.onClick.AddListener(getEstadoCilindro);
            

        }
        public void CreateFig( )
        {
            Destroy(GameObject.Find("Esfera(Clone)"));
            Destroy(GameObject.Find("Cilindro(Clone)"));
            Destroy(GameObject.Find("Cubo(Clone)"));
            _figurasFactory.Create(id);
        }

        private void getEstadoEsfera()
        {
            
            id = "esfera";
        }
        private void getEstadoCilindro()
        {
            id = "cilindro";
        }
        private void getEstadoCubo()
        {

            id = "cubo";
        }

        

    }
}
