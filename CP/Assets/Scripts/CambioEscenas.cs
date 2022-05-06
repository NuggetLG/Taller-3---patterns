using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenas : MonoBehaviour
{

    public Button btnScene1;
    public Button btnScene2;
    public Button btnScene3;
    public Button btnSalir;
    private string nombre;
    void Start()
    {
        btnScene1 = GameObject.Find("btnScene1").GetComponent<Button>();
        btnScene2 = GameObject.Find("btnScene2").GetComponent<Button>(); 
        btnScene3 = GameObject.Find("btnScene3").GetComponent<Button>();
        btnSalir = GameObject.Find("btnSalir").GetComponent<Button>();
        btnScene1.onClick.AddListener(setScene1);
        btnScene2.onClick.AddListener(setScene2);
        btnScene3.onClick.AddListener(setScene3);
        btnSalir.onClick.AddListener(Salir);

    }
    public void setScene1()
    {
        nombre = "Scene1";
        ChangeScene();
    }
    public void setScene2()
    {
        nombre = "Scene2";
        ChangeScene();
    }
    public void setScene3()
    {
        nombre = "Scene3";
        ChangeScene();
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        Application.Quit();
    }

}
