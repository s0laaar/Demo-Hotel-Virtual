using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonAbrir : MonoBehaviour
{
    public GameObject Abrir;
    public GameObject Actual;

    public void OpenPanel()
    {
        if (Abrir != null)
        {
            Abrir.SetActive(true);
            Actual.SetActive(false);
        }
        Actual.SetActive(false);
    }
}
