using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class ItemData : ScriptableObject
{
    public string id;
    public string nombre;
    public string descripcion;
    public Sprite icono;
    public GameObject prefab;
}
