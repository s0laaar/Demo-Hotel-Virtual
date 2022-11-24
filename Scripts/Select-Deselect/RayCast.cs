using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RayCast : MonoBehaviour
{
    [SerializeField] private GameObject boxDetect;
    [SerializeField] private LayerMask mascara;
    [SerializeField] private Transform zonaOrigenBoxDet;

    [SerializeField] private Image punteroImagen;
    [SerializeField] private Sprite spriteMira, spriteMano;

    [SerializeField] public GameObject TextDetect;

    private int rango = 3;

    private void Update() 
    {
        RaycastHit hit;
        if(Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, rango, mascara))
        {
            if(hit.collider.GetComponent<Outline>()==true && hit.collider.CompareTag("Item") ){
                boxDetect.GetComponent<Transform>().position = hit.collider.GetComponent<Transform>().position;
                punteroImagen.sprite = spriteMano;
                TextDetect.SetActive(true);
            }
            else
            {
                boxDetect.GetComponent<Transform>().position = zonaOrigenBoxDet.position;
                punteroImagen.sprite = spriteMira;
                TextDetect.SetActive(false);
            }

        }
        else
        {
            boxDetect.GetComponent<Transform>().position = zonaOrigenBoxDet.position;
            punteroImagen.sprite = spriteMira;
            TextDetect.SetActive(false);
        }
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(gameObject.transform.position, gameObject.transform.forward * rango);
    }

}
