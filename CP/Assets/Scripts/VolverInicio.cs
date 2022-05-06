using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class VolverInicio : MonoBehaviour
{
    public Button btnVolver;

   void Start()
    {
        btnVolver = GameObject.Find("Volver").GetComponent<Button>();
        btnVolver.onClick.AddListener(Back);
    }
    public void Back()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
