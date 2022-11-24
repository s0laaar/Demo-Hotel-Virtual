using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarTriggerSiguiente : MonoBehaviour
{
    public GameObject TriggerHabitacion;

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player"))
        {
            TriggerHabitacion.SetActive(true);
        }
    }
}
