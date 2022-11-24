using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarSensores : MonoBehaviour
{
    // Sensor que se desactivar�
    public GameObject sensor;

    // Funci�n activada cuando se soliciona con otro collider
    private void OnTriggerEnter(Collider other)
    {
        // Si colisiona con el jugador, se procede
        if (other.tag == "Player")
        {
            // Se desactiva el sensor
            sensor.SetActive(false);
        }
    }
}
