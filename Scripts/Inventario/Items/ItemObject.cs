using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public ItemData itemReferencia;
    private SistemaInventario inventario;
    private void Awake()
    {
        inventario = GameObject.FindGameObjectWithTag("SistemaInventario").GetComponent<SistemaInventario>();
    }
    public void Inventariar()
    {   //Anade item a la lista y destruye GameObject de la escena
        if(itemReferencia.id == "3"){
            inventario.Add(itemReferencia);
            Destroy(gameObject);  
        }
        else if(itemReferencia.id == "2"){
            inventario.Add(itemReferencia);
            Destroy(gameObject);  
        }
        else if(itemReferencia.id == "1"){
            inventario.Add(itemReferencia);
            Destroy(gameObject);  
        }
        
        
    }

    public void Dejar()
    {
        inventario.Remove(itemReferencia);
    }
}
