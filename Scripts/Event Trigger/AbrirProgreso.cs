using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirProgreso : MonoBehaviour
{
    public GameObject objetoOculto;
    public Boolean obj1activo;
    public GameObject objetoOculto1;
    public Boolean obj2activo;


    public int repeticion;

    public PlayerCommands inventarioCommands;

    private GameObject miniMap;

    public ListaCompletado listaCompletado;

    void Start()
    {
        objetoOculto.SetActive(false);
        miniMap = GameObject.Find("MinimapBorder");
    }
    // Update is called once per frame
    void Update()
    {   
        if(obj1activo == true && obj2activo == true)
        {
            objetoOculto.SetActive(false);
        }

        if (repeticion == 0)
        {
            if (inventarioCommands.inventoryEnabled == false)
            {
                if (listaCompletado.completo > 3)
                {
                    obj1activo = true;

                    if (obj1activo)
                    {
                        objetoOculto.SetActive(true);
                        repeticion = 1;
                        Time.timeScale = 0;
                        FirstPersonLook.shouldExecuteLook = false;

                    
                        Cursor.visible = true;
                        miniMap.SetActive(false);
                        Cursor.lockState = CursorLockMode.None;
                        AcercarseTrigger.condicional = 1;
                    }
                    
                }
            }

        }
        


        if (repeticion == 1)
        {
            if (inventarioCommands.inventoryEnabled == false)
            {             
                if (listaCompletado.completo >= 8)
                {
                    obj2activo = true;

                    if (obj2activo)
                    {
                        objetoOculto1.SetActive(true);
                        repeticion = 2;
                        Time.timeScale = 0;
                        FirstPersonLook.shouldExecuteLook = false;

                        Cursor.visible = true;
                        miniMap.SetActive(false);
                        Cursor.lockState = CursorLockMode.None;
                        AcercarseTrigger.condicional = 1;
                    }
                    
                }              
            }
        }

    }
}
