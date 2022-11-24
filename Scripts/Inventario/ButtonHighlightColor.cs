using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHighlightColor : MonoBehaviour
{
    public GameObject BarraIzqierda;
    public GameObject BarraDerecha;

    public Image Fondo;
    public Image ImagenTexto;

    public Sprite FondoNormal;
    public Sprite FondoPoint;
    public Sprite ImagenNormal;
    public Sprite ImagenPoint;

    public void OnPointer()
    {
        BarraIzqierda.SetActive(true);
        BarraDerecha.SetActive(true);
        Fondo.sprite = FondoPoint;
        ImagenTexto.sprite = ImagenPoint;
    }

    public void OnExit()
    {
        BarraIzqierda.SetActive(false);
        BarraDerecha.SetActive(false);
        Fondo.sprite = FondoNormal;
        ImagenTexto.sprite = ImagenNormal;
    }
}
