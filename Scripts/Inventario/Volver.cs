using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volver : MonoBehaviour
{
    public GameObject volver;
    public GameObject actual;

    public void OpenPanel()
    {
        if (volver != null)
        {
            volver.SetActive(true);
            actual.SetActive(false);
        }
    }
}
