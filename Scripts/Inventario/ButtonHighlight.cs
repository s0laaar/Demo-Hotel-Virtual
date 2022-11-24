using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHighlight : MonoBehaviour
{
    public GameObject textoboton;

    public void OnPointer()
    {
        textoboton.SetActive(true);
    }

    public void OnExit()
    {
        textoboton.SetActive(false);
    }

}
