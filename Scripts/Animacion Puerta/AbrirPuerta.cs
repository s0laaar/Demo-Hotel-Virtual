using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
   // Velocidad a la que se movera la puerta

    float smooth        = 4.0f;

    // Angulo que girara la puerta

    float DoorOpenAngle = 90.0f;

    // Variabale para que indicara si hay que abrir la puerta
    private bool open;

    // Variabe que indicara si el personaje ha entrado en colision con el collider
    //  de interaccion con la puerta
    private bool enter;

    // Posicion y rotacion inicial de la visagra de la puerta
    private Vector3 defaultRot;

    // Posicion y rotacion de la visagra cuando se encuentra abierta

    private Vector3 openRot;

    // Raiz del objeto de la puerta

    public GameObject door;

    public GameObject Player;

    // AudioSource asignado en el objeto door
    public AudioSource audioSource;

    // Clips de audio
    public AudioClip closeDoorAudio;
    public AudioClip openDoorAudio;

    void Start()
    {
        // Se guarda la posicion inicial de la visagra
        defaultRot = transform.eulerAngles;

        // Se guarda la posicion final de la visagra

        openRot = new Vector3(defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);

        // Hacemos referencia al audiosource asignado en la raiz (door)
        audioSource = Player.GetComponent<AudioSource>();
    }
    
    // Funcion que se llama automatimente y continuamente por unity

    void Update()
    {
        // Comprueba si hay que abrir la puerta si open es igual a true
        if (open)
        {
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
        }
        // Si la puerta no esta abierta se cierra
        else
        {
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
        }

        // Comprueba si el usuario a pulsado la tecla F y esta dentro del collider de la puerta

        if (Input.GetMouseButtonDown(0) && enter )
        {
            // en caso de que sea cierto la variable open tomara el valor de true
            // con esto conseguiremos que cuando unity llame a la funcion update
            // entre en el caso de abrir puerta
            open = !open;

            if (open)
            {
                // Si se se va a abrir la puerta se asigna la velocidad de movimiento de
                //apertura de la puerta
                smooth = 4.0f;
                // Se asigna el clip de audio al audiosource
                audioSource.clip = openDoorAudio;
                // Se reproduce el sonido
                audioSource.Play();
            }
            else
            {
                // Si se se va a cerrar la puerta se asigna la velocidad de movimiento de
                //cierre de la puerta
                smooth = 7.0f;
                // Se asigna el clip de audio al audiosource
                audioSource.clip = closeDoorAudio;
                // Se repodruce el sonido
                audioSource.Play();
            }
        }
    }
    
    // Funcion que pintara en pantalla un mensaje de interaccion
    private void OnGUI()
    {
        // Si el player ha entrado en contacto con el collider de la puerta
        if (enter)
        {
            // Se muestra el mensaje de interaccion
            //GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Press 'F' to open the door");
        }
    }
    
    /**************************************************************************************/
    /*              Triggers                                                              */
    /**************************************************************************************/
    
    // IMPORTANTE: PARA QUE ESTOS TRIGGERS FUNCIONEN EL OBJETO AL QUE ESTA ASIGNADO ESTE SCRIPT
    // DEBE TENER UN COLLIDER ASIGNADO CON LA PROPIEDAD ISTRIGGER ACTIVADA

    // Trigger que detecta cuando un objeto ha entrado en colision con el objeto que tiene asignado este script
    private void OnTriggerEnter(Collider other)
    {
        // Si el objeto que ha entrado en colision es el player
        if (other.gameObject.tag == "Player")
        {
            // Colocamos la variable enter a true
            enter = true;
        }
    }

    // Trigger que detecta cuando un objeto ha salido de colision con el objeto que tiene asignado este script
    private void OnTriggerExit(Collider other)
    {
        // Si el objeto que ha salido de colision es el player
        if (other.gameObject.tag == "Player")
        {
            // Colocamos la variable enter a false
            enter = false;
        }
    }
}
