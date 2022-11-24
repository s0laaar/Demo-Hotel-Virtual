using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarInventario : MonoBehaviour
{
    public PlayerCommands inventarioCommands;

    public GameObject InventarioPrincipal;
    public GameObject Inventario1;
    public GameObject Inventario2;
    public GameObject Inventario3;
    public GameObject menuPantallas;


    public void CerrarI()
    {
        inventarioCommands.inventoryEnabled = false;
        InventarioPrincipal.SetActive(true);
        Inventario1.SetActive(false);
        Inventario2.SetActive(false);
        Inventario3.SetActive(false);
        menuPantallas.SetActive(false);

    }
}
