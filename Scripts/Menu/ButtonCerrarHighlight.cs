using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCerrarHighlight : MonoBehaviour
{
    public Image Fondo;

    public Sprite FondoNormal;
    public Sprite FondoPoint;

    public Text text;

    public Color colorNormal;
    public Color colorPoint;

    public void OnPointer()
    {
        Fondo.sprite = FondoPoint;
        text.color = colorPoint;
    }

    public void OnExit()
    {
        Fondo.sprite = FondoNormal;
        text.color = colorNormal;
    }

    public void OnClick()
    {
        Fondo.sprite = FondoNormal;
        text.color = colorNormal;
    }
}
