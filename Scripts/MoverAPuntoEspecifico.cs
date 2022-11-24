using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoverAPuntoEspecifico : MonoBehaviour
{
    // Variable que contendr� el mecanismo de navegaci�n autom�tica del personaje
    NavMeshAgent navMeshAgent;
    // Variables que mostrar�n el punto al que debe llegar el personaje una vez abierta la puerta
    public GameObject objetivoPosterior, objetivoPosterior2, objetivoAnterior, objetivoPosteriorSala, objetivoPosterior2Sala, objetivoAnteriorSala, objetivoPosteriorDormitorio, objetivoPosterior2Dormitorio, objetivoAnteriorDormitorio, objetivoPosteriorBa�o, objetivoPosterior2Ba�o, objetivoAnteriorBa�o, objetivoPosteriorVestidor, objetivoPosterior2Vestidor, objetivoAnteriorVestidor, objetivoPosteriorEstudio, objetivoPosterior2Estudio, objetivoAnteriorEstudio, objetivoPosteriorBa�oVestidor, objetivoPosterior2Ba�oVestidor, objetivoAnteriorBa�oVestidor, objetivoPosteriorWcBa�o, objetivoPosterior2WcBa�o, objetivoAnteriorWcBa�o;
    // Variable que contendr� el sonido cuando se cierre una puerta
    public AudioClip audioPuertaCerrada;
    // Componente que gestionar� el audio que reproducir� el personaje
    private AudioSource audioSource;

    // Funci�n invocada al comienzo, cuando comienza a existir este objeto (en este caso, el personaje)
    void Awake()
    {
        // Capturamos el componente de navegaci�n en la variable especificada,
        // esto nos permitir� interactuar con dicho componente
        navMeshAgent = GetComponent<NavMeshAgent>();
        // Capturamos en la variable el componente que gestiona el audio
        audioSource = GetComponent<AudioSource>();
        // Asignamos a la variable el clip de sonido especificado en el inspector de unity
        audioSource.clip = audioPuertaCerrada;
    }

    //// Funci�n invocada permanentemente por unity
    //void Update()
    //{
    //    // Se invoca constantemente el m�todo indicado enviandole el estado de los objetivos de las puertas de todo el escenario
    //    establecerObjetivo(objetivoPosterior, objetivoPosterior2, objetivoAnterior);
    //    establecerObjetivo(objetivoPosteriorSala, objetivoPosterior2Sala, objetivoAnteriorSala);
    //    establecerObjetivo(objetivoPosteriorDormitorio, objetivoPosterior2Dormitorio, objetivoAnteriorDormitorio);
    //    establecerObjetivo(objetivoPosteriorBa�o, objetivoPosterior2Ba�o, objetivoAnteriorBa�o);
    //    establecerObjetivo(objetivoPosteriorVestidor, objetivoPosterior2Vestidor, objetivoAnteriorVestidor);
    //    establecerObjetivo(objetivoPosteriorEstudio, objetivoPosterior2Estudio, objetivoAnteriorEstudio);
    //    establecerObjetivo(objetivoPosteriorBa�oVestidor, objetivoPosterior2Ba�oVestidor, objetivoAnteriorBa�oVestidor);
    //    establecerObjetivo(objetivoPosteriorWcBa�o, objetivoPosterior2WcBa�o, objetivoAnteriorWcBa�o);
    //}

    // Funci�n que mueve al personaje al destino especificado
    void Mover(Vector3 posicion)
    {
        // Se establece el destino de la navegaci�n
        navMeshAgent.SetDestination(posicion);
    }

    private void establecerObjetivo (GameObject objetivo, GameObject objetivo2, GameObject objetivo3)
    {
        // Si el objetivo especificado est� activo, se procede
        if (objetivo.activeSelf == true)
        {
            // Se activa el navegador
            navMeshAgent.enabled = true;
            // Se convoca el m�todo especificado, entreg�ndole la posici�n del objetivo
            Mover(objetivo.transform.position);
        }
        // Si el objetivo especificado est� activo, se procede
        if (objetivo2.activeSelf == true)
        {
            // Se activa el navegador
            navMeshAgent.enabled = true;
            // Se incrementa la velocidad a la que se mover� el personaje
            navMeshAgent.speed = 15;
            // Se convoca el m�todo especificado, entreg�ndole la posici�n del objetivo
            Mover(objetivo2.transform.position);
        }
        // Si el objetivo especificado est� activo, se procede
        if (objetivo3.activeSelf == true)
        {
            // Se activa el navegador
            navMeshAgent.enabled = true;
            // Se incrementa la velocidad a la que se mover� el personaje
            navMeshAgent.speed = 3;
            // Se convoca el m�todo especificado, entreg�ndole la posici�n del objetivo
            Mover(objetivo3.transform.position);
        }
    }

    // Funci�n que detecta que el personaje colisiona con otro collider
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
