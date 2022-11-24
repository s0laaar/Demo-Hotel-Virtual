using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoLocalizacion : MonoBehaviour
{
    public Text textoActual;

    public Text textoBoton;

    //public GameObject slots;
    //public ButtonHighlight slotsOcupados;


    void Update ()
    {
        //slotsOcupados.Variable
        textoActual.text = "x " + "pts." + "\n" + "\n" + textoBoton.text.ToUpper();
    }
}
