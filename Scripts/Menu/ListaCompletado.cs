using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListaCompletado : MonoBehaviour
{

    public Text textoActual;
    public float completo;
    public float calculo;
    public ToggleBoolean toggle1;
  
    public ToggleBoolean toggle3;
    public ToggleBoolean toggle4;
    public ToggleBoolean toggle5;
    public ToggleBoolean toggle6;
    public ToggleBoolean toogle7;
    public ToggleBoolean toogle8;
    public ToggleBoolean toogle9;


    


    // Update is called once per frame
    void Update()
    {
        completo = toggle1.valor +  toggle3.valor + toggle4.valor + toggle5.valor + toggle6.valor + toogle7.valor + toogle8.valor +toogle9.valor ;
        calculo = Mathf.Round(100 * completo / 8);
        textoActual.text = calculo + "% " + "Completado";
    }
}
