using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirLista : MonoBehaviour
{
    public PlayerCommands inventarioCommands;

    private GameObject miniMap;
    public int repeticion;

    public GameObject objetoOculto;

    public GameObject inventario;
    public GameObject pantallaInventario;
    public GameObject pantallaMenu;
    public GameObject lista;



    void Start()
    {
        miniMap = GameObject.Find("MinimapBorder");
    }

    public void OnButtonEnter()
    {
        inventarioCommands.inventoryEnabled = true;
        repeticion = 1;
        AcercarseTrigger.condicional = 0;
        objetoOculto.SetActive(false);
        inventario.SetActive(true);
        pantallaInventario.SetActive(false);
        lista.SetActive(true);
        pantallaMenu.SetActive(true);
    }

    private void Update() {
        if(Input.GetKey(KeyCode.Space))
        {
            OnButtonEnter();
        }
    }

}
