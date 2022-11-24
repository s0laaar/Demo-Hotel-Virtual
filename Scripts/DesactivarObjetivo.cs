using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarObjetivo : MonoBehaviour
{
    // Objetivo que se desactivará
    public GameObject objetivo;
    // Sensores que se desactivarán
    public GameObject sensorAnterior;
    public GameObject sensorPosterior;
    private AudioSource audioSource;
    public AudioClip openDoorAudio;
    

    private void Start()
    {
        audioSource = objetivo.GetComponent<AudioSource>();
        audioSource.clip = openDoorAudio;
        audioSource.Play();
    }

    // Método convocado cuando este objeto colisione con otro collider
    private void OnTriggerEnter(Collider other)
    {
        // Si se colisiona con un objeto etiquetado como se especifica, se procede
        if (other.tag == "Player")
        {
            // Se desactiva el objetivo
            objetivo.SetActive(false);
            // Se desactivan los sensores
            sensorAnterior.SetActive(false);
            sensorPosterior.SetActive(false);
        }
    }
}
