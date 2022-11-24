using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleBoolean : MonoBehaviour
{
    public int valor;
    public Toggle toggle;

    public void check()
    {
        if (toggle.isOn == true)
        {
            valor = 1;
        } else
        {
            valor = 0;
        }
    }
}
