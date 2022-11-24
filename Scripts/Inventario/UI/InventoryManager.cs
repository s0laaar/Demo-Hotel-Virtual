using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    private GameObject m_slotPrefab;

    public SistemaInventario sistema;

    public void OnUpdateInventory()
    {
        //Destruye inventario actual para volver a generarlo (En caso que esto no exista tendremos objetos iguales duplicados en el inventario)
        foreach (Transform  t in transform)
        {
            Destroy(t.gameObject);
        }
        DrawInventory();
    }

    public void DrawInventory()
    {
        //Recorre lista de objetos y los genera dentro del inventario
        foreach (ItemInventario item in sistema.inventario)
        {
            AddInventorySlot(item);
        }
    }

    public void AddInventorySlot(ItemInventario item)
    {
        //Genera nuevo slot en SlotPanel
        GameObject obj = Instantiate(m_slotPrefab);
        obj.transform.SetParent(transform, false);
        Slots slot = obj.GetComponent<Slots>();
        slot.Set(item);
    }
}
