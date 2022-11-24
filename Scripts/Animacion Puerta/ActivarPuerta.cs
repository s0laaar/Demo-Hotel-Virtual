using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ActivarPuerta : MonoBehaviour
{
    [SerializeField] private GameObject puerta;
    [SerializeField] private GameObject llave;
    
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.Equals(llave))
        {
            puerta.GetComponent<AbrirPuerta>().enabled = true;
        }
    }
}
