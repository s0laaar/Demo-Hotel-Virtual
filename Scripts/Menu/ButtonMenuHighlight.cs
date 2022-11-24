using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonMenuHighlight : MonoBehaviour
{
    public Image Fondo;

    public Sprite FondoNormal;
    public Sprite FondoPoint;

    public Color colorNormal;
    public Color colorPoint;


    public void OnPointer()
    {
        colorPoint.a = 1f;
        Fondo.sprite = FondoPoint;
        Fondo.color = colorPoint;
    }

    public void OnExit()
    {
        colorNormal.a = 0.01f;
        Fondo.sprite = FondoNormal;
        Fondo.color = colorNormal;
    }
}
