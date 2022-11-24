using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManagment : MonoBehaviour
{
    public GameObject Panel_Principal;
    public GameObject Panel_Actual;


    public GameObject Fondo;
    public GameObject Lista;
    public GameObject Opciones;
    public GameObject ReiniciarNivel;
    public GameObject BIzq;
    public GameObject BCen;
    public GameObject BDer;
    public GameObject Salir;




    public GameObject CerrarButton;


    //Funcion que activa gameobjects previamente desactivados
    public void CargarPanelPrincipal(){
        Panel_Actual.SetActive(false);
        Panel_Principal.SetActive(true);
        Fondo.SetActive(true);
        Lista.SetActive(true);
        Opciones.SetActive(true);
        ReiniciarNivel.SetActive(true);
        BIzq.SetActive(true);
        BCen.SetActive(true);
        BDer.SetActive(true);
        Salir.SetActive(true);
        CerrarButton.SetActive(true);
        
    }

    //Funcion que desactiva gameobjects que se visualizan debajo
    //de pantalla Ayuda
    public void DesactivarPanelActual(){
        Fondo.SetActive(false);
        Lista.SetActive(false);
        Opciones.SetActive(false);
        ReiniciarNivel.SetActive(false);
        BIzq.SetActive(false);
        BCen.SetActive(false);
        BDer.SetActive(false);
        Salir.SetActive(false);
        CerrarButton.SetActive(false);
    }

    public void ActivarPanelActual(){

    }
}
