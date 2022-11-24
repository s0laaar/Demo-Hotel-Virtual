using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAbrirLista : MonoBehaviour
{
    public GameObject objetoOcu;

    private GameObject miniM;

    public static int condic;
    public int repet;


    void Start()
    {
        objetoOcu.SetActive(false);
        miniM = GameObject.Find("MinimapBorder");
    }

    public void OnTriggerEnter(Collider other) {
        if (repet == 0)
        {
            if (other.CompareTag("Player"))
            {
                objetoOcu.SetActive(true);
                Time.timeScale = 0;
                FirstPersonLook.shouldExecuteLook = false;
                Cursor.visible = true;
                miniM.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                condic = 1;
                repet = 1;
            }
        }
    }
}
