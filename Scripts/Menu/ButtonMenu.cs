using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenu : MonoBehaviour
{
    public GameObject Abrir;
    public GameObject menuPantalla;
    public GameObject menu1;
    public GameObject inventario;

    public void OpenPanel()
    {
        Abrir.SetActive(true);
        menuPantalla.SetActive(true);
        menu1.SetActive(false);
        inventario.SetActive(false);

    }
}
