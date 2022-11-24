using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaRayo : MonoBehaviour
{
  private void OnTriggerEnter(Collider other) 
  {
    gameObject.GetComponent<Outline>().enabled = true;
  }

  private void OnTriggerExit(Collider other) 
  {
    gameObject.GetComponent<Outline>().enabled = false;
  }
}
