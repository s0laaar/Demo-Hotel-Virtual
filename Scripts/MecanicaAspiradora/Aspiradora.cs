using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aspiradora : MonoBehaviour
{
    public GameObject tuboAspiradora;
    public GameObject aspiradora;
    public LayerMask mugreLayer;
    public float distanciaMaxima;
    public bool estaSiendoUsada;
    public AudioSource sfxSource;
    public AudioClip clip;
    Mugre mugre;

    private void Update()
    {
        if(estaSiendoUsada)
        {
            if(Input.GetKey("f"))
            {
                Limpiar();
                //Pide audio clip y lo hace sonar una sola vez
                sfxSource.PlayOneShot(clip);
                //
                sfxSource.clip = clip;
                sfxSource.loop = true;
                sfxSource.volume = 0.2f;
                sfxSource.Play();
            }
            else
            {
                if(sfxSource.isPlaying) sfxSource.Stop();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                DejarDeUsarAspiradora();
            }
        }
    }

    public void UsarAspiradora()
    {
        tuboAspiradora.SetActive(true);
        aspiradora.SetActive(false);
        estaSiendoUsada = true;
    }

    public void Limpiar()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distanciaMaxima, mugreLayer))
        {
            if (mugre == null || mugre != hit.collider.GetComponent<Mugre>())
            {
                mugre = hit.collider.GetComponent<Mugre>();
            }
            else
            {
                if (!mugre.estaLimpio)
                {
                    mugre.LimpiarMugre();
                }
            }
        }
    }

    public void DejarDeUsarAspiradora()
    {
        estaSiendoUsada = false;
        tuboAspiradora.SetActive(false);
        aspiradora.SetActive(true);
    }
}
