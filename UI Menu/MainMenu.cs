using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panelPrincipal;
    public GameObject panelOpciones;

    //metodo que carga el nivel correspondiente
    public void CargarNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }

    //metodo que cierra el juego
    public void Salir()
    {
        Application.Quit();
    }

    //Método que carga el panel de opciones
    public void CargarPanelOpciones()
    {
        panelPrincipal.SetActive(false);
        panelOpciones.SetActive(true);
    }

    //Método que carga el panel principal
    public void CargarPanelPrincipal()
    {
        panelPrincipal.SetActive(true);
        panelOpciones.SetActive(false);
    }
}
