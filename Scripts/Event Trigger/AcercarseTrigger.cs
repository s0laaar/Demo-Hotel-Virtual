using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcercarseTrigger : MonoBehaviour
{
    public GameObject objetoOculto;

    public ListaCompletado listaCompletado;

    private GameObject miniMap;

    public static int condicional;
    public int repeticion;

    void Start()
    {
        objetoOculto.SetActive(false);
        miniMap = GameObject.Find("MinimapBorder");
    }

    public void OnTriggerEnter (Collider coll)
    {
        if (repeticion == 0)
        {
            if (coll.CompareTag("Player"))
            {
                objetoOculto.SetActive(true);
                Time.timeScale = 0;
                FirstPersonLook.shouldExecuteLook = false;
                Cursor.visible = true;
                miniMap.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                condicional = 1;
                repeticion = 1;
            }
        }
    }
    private void Update() {
        if(Input.GetKey(KeyCode.Space))
        {
            objetoOculto.SetActive(false);
            condicional = 0;
        }
    }



}
