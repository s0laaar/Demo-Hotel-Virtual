using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarHabitacionOrigen : MonoBehaviour
{
    public GameObject habitacionOrigen, elementoExtra1, elementoExtra2, elementoExtra3, elementoExtra4, elementoExtra5, elementoExtra6;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            habitacionOrigen.SetActive(false);
            elementoExtra1.SetActive(false);
            elementoExtra2.SetActive(false);
            elementoExtra3.SetActive(false);
            elementoExtra4.SetActive(false);
            elementoExtra5.SetActive(false);
            elementoExtra6.SetActive(false);
        }
    }
}
