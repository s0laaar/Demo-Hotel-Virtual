using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevisaPregunta : MonoBehaviour
{
    public InputField respuesta;
    public static int contador;

    public GameObject pregunta1;
    public GameObject pregunta2;

    public void Corregir()
    {
        if (pregunta1.activeSelf)
        {
            if (respuesta.text == "5")
            {
                contador = contador + 1;
            }
        }
        if (pregunta2.activeSelf)
        {
            if (respuesta.text == "hola")
            {
                contador = contador + 1;
            }
        }
    }
}
