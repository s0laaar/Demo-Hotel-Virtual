using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoverAPuntoEspecifico : MonoBehaviour
{
    // Variable que contendrá el mecanismo de navegación automática del personaje
    NavMeshAgent navMeshAgent;
    // Variables que mostrarán el punto al que debe llegar el personaje una vez abierta la puerta
    public GameObject objetivoPosterior, objetivoPosterior2, objetivoAnterior, objetivoPosteriorSala, objetivoPosterior2Sala, objetivoAnteriorSala, objetivoPosteriorDormitorio, objetivoPosterior2Dormitorio, objetivoAnteriorDormitorio, objetivoPosteriorBaño, objetivoPosterior2Baño, objetivoAnteriorBaño, objetivoPosteriorVestidor, objetivoPosterior2Vestidor, objetivoAnteriorVestidor, objetivoPosteriorEstudio, objetivoPosterior2Estudio, objetivoAnteriorEstudio, objetivoPosteriorBañoVestidor, objetivoPosterior2BañoVestidor, objetivoAnteriorBañoVestidor, objetivoPosteriorWcBaño, objetivoPosterior2WcBaño, objetivoAnteriorWcBaño;
    // Variable que contendrá el sonido cuando se cierre una puerta
    public AudioClip audioPuertaCerrada;
    // Componente que gestionará el audio que reproducirá el personaje
    private AudioSource audioSource;

    // Función invocada al comienzo, cuando comienza a existir este objeto (en este caso, el personaje)
    void Awake()
    {
        // Capturamos el componente de navegación en la variable especificada,
        // esto nos permitirá interactuar con dicho componente
        navMeshAgent = GetComponent<NavMeshAgent>();
        // Capturamos en la variable el componente que gestiona el audio
        audioSource = GetComponent<AudioSource>();
        // Asignamos a la variable el clip de sonido especificado en el inspector de unity
        audioSource.clip = audioPuertaCerrada;
    }

    //// Función invocada permanentemente por unity
    //void Update()
    //{
    //    // Se invoca constantemente el método indicado enviandole el estado de los objetivos de las puertas de todo el escenario
    //    establecerObjetivo(objetivoPosterior, objetivoPosterior2, objetivoAnterior);
    //    establecerObjetivo(objetivoPosteriorSala, objetivoPosterior2Sala, objetivoAnteriorSala);
    //    establecerObjetivo(objetivoPosteriorDormitorio, objetivoPosterior2Dormitorio, objetivoAnteriorDormitorio);
    //    establecerObjetivo(objetivoPosteriorBaño, objetivoPosterior2Baño, objetivoAnteriorBaño);
    //    establecerObjetivo(objetivoPosteriorVestidor, objetivoPosterior2Vestidor, objetivoAnteriorVestidor);
    //    establecerObjetivo(objetivoPosteriorEstudio, objetivoPosterior2Estudio, objetivoAnteriorEstudio);
    //    establecerObjetivo(objetivoPosteriorBañoVestidor, objetivoPosterior2BañoVestidor, objetivoAnteriorBañoVestidor);
    //    establecerObjetivo(objetivoPosteriorWcBaño, objetivoPosterior2WcBaño, objetivoAnteriorWcBaño);
    //}

    // Función que mueve al personaje al destino especificado
    void Mover(Vector3 posicion)
    {
        // Se establece el destino de la navegación
        navMeshAgent.SetDestination(posicion);
    }

    private void establecerObjetivo (GameObject objetivo, GameObject objetivo2, GameObject objetivo3)
    {
        // Si el objetivo especificado está activo, se procede
        if (objetivo.activeSelf == true)
        {
            // Se activa el navegador
            navMeshAgent.enabled = true;
            // Se convoca el método especificado, entregándole la posición del objetivo
            Mover(objetivo.transform.position);
        }
        // Si el objetivo especificado está activo, se procede
        if (objetivo2.activeSelf == true)
        {
            // Se activa el navegador
            navMeshAgent.enabled = true;
            // Se incrementa la velocidad a la que se moverá el personaje
            navMeshAgent.speed = 15;
            // Se convoca el método especificado, entregándole la posición del objetivo
            Mover(objetivo2.transform.position);
        }
        // Si el objetivo especificado está activo, se procede
        if (objetivo3.activeSelf == true)
        {
            // Se activa el navegador
            navMeshAgent.enabled = true;
            // Se incrementa la velocidad a la que se moverá el personaje
            navMeshAgent.speed = 3;
            // Se convoca el método especificado, entregándole la posición del objetivo
            Mover(objetivo3.transform.position);
        }
    }

    // Función que detecta que el personaje colisiona con otro collider
    //private void OnTriggerEnter(Collider other)
    //{
    //    // Si colisiona con el objeto cuya etqueta es la especificada, se procede
    //    if (other.tag == "Objetivo")
    //    {
    //        // Se desactiva el navegador para permitir el control del personaje por el usuario
    //        navMeshAgent.enabled = false;
    //        audioSource.Play();
    //    }
    //}
}
