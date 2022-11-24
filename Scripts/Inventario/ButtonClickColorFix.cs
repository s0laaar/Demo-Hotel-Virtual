using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickColorFix : MonoBehaviour
{

    public GameObject textoboton;
    public GameObject BarraIzqierda;
    public GameObject BarraDerecha;

    public Image Fondo;
    public Image ImagenTexto;

    public Sprite FondoNormal;
    public Sprite ImagenNormal;

    public void OnCLickColor()
    {
        BarraIzqierda.SetActive(false);
        BarraDerecha.SetActive(false);
        Fondo.sprite = FondoNormal;
        ImagenTexto.sprite = ImagenNormal;
        textoboton.SetActive(false);
    }

}
