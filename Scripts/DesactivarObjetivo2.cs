using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarObjetivo2 : MonoBehaviour
{
    // Objetivo que se desactivar�
    public GameObject objetivo;
    // Sensores que se desactivar�n
    public GameObject sensorAnterior;
    public GameObject sensorPosterior;
    // Objetivo que se activar�
    public GameObject objetivo3;

    // M�todo convocado cuando este objeto colisione con otro collider
    private void OnTriggerEnter(Collider other)
    {
        // Si se colisiona con un objeto etiquetado como se especifica, se procede
        if (other.tag == "Player")
        {
            // Se activa el siguiente objetivo
            objetivo3.SetActive(true);
            // Se desactiva el objetivo
            objetivo.SetActive(false);
            // Se desactivan los sensores
            sensorAnterior.SetActive(false);
            sensorPosterior.SetActive(false);
        }
    }
}
