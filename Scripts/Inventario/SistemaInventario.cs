using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaInventario : MonoBehaviour
{
    public InventoryManager managerInventarioLiving;
    // ID = 3
    public InventoryManager managerInventarioDormitorio;
    // ID = 2
    public InventoryManager managerInventarioBano;
    // ID = 1

    private Dictionary<ItemData, ItemInventario> m_itemDictionary;



    public List<ItemInventario> inventario { get; private set; }

    private void Awake()
    {
        //Genera nuevas listas de items y stacks
        inventario = new List<ItemInventario>();
        m_itemDictionary = new Dictionary<ItemData, ItemInventario>();
    }

    public ItemInventario Get(ItemData dataReferencia)
    {
        if (m_itemDictionary.TryGetValue(dataReferencia, out ItemInventario value))
        { 
            return value;          
        }
        return null;
    }

    public void Add(ItemData dataReferencia)
    {
        //Si el objeto existe dentro de la lista, a�ade uno al stack de este. Si no existe lo a�ade a la lista
        if (m_itemDictionary.TryGetValue(dataReferencia, out ItemInventario value))
        {
            if(dataReferencia.id == "3"){
                value.AddToStack();

                //Actualiza el inventario dentro del juego
                managerInventarioLiving.OnUpdateInventory();
            }
            else if(dataReferencia.id == "2"){
                value.AddToStack();

                //Actualiza el inventario dentro del juego
                managerInventarioDormitorio.OnUpdateInventory();
            }
            else if(dataReferencia.id == "1"){
                value.AddToStack();

                //Actualiza el inventario dentro del juego
                managerInventarioBano.OnUpdateInventory();
            }
        }
        else
        {
            ItemInventario newItem = new ItemInventario(dataReferencia);
            inventario.Add(newItem);
            m_itemDictionary.Add(dataReferencia, newItem);
            
            if(dataReferencia.id == "3"){
                //Actualiza el inventario dentro del juego
                
                managerInventarioLiving.OnUpdateInventory();
            }
            else if(dataReferencia.id == "2"){
                //Actualiza el inventario dentro del juego
                managerInventarioDormitorio.OnUpdateInventory();    
            }
            else if(dataReferencia.id == "1"){
                //Actualiza el inventario dentro del juego
                managerInventarioBano.OnUpdateInventory(); 
            }

            
        }
    }

    public void Remove(ItemData dataReferencia)
    {
        //Si el objeto existe dentro de la lista, quita uno al stack de este. Si no existe lo elimina a la lista
        if (m_itemDictionary.TryGetValue(dataReferencia, out ItemInventario value))
        {

            if(dataReferencia.id == "3")
            {
                value.RemoveFromStack();
                //Actualiza el inventario dentro del juego
                managerInventarioLiving.OnUpdateInventory();
            }
            else if(dataReferencia.id == "2")
            {
                value.RemoveFromStack();
                //Actualiza el inventario dentro del juego
                managerInventarioDormitorio.OnUpdateInventory();
            }
            else if(dataReferencia.id == "1")
            {
                value.RemoveFromStack();
                //Actualiza el inventario dentro del juego
                managerInventarioBano.OnUpdateInventory();
            }
            
        }
        if(value.stackSize == 0)
        {
            inventario.Remove(value);
            m_itemDictionary.Remove(dataReferencia);

            //Actualiza el inventario dentro del juego
            managerInventarioLiving.OnUpdateInventory();
            managerInventarioDormitorio.OnUpdateInventory();
            managerInventarioBano.OnUpdateInventory();
        }
    }
}
