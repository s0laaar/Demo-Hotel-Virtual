using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivaUI : MonoBehaviour
{   
    public GameObject TextDetect;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            TextDetect.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player"))
        {
            TextDetect.SetActive(false);
        }
    }
}
