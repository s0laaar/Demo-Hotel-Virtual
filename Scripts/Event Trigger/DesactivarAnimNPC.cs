using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarAnimNPC : MonoBehaviour
{
    public GameObject NPC;
    public GameObject Objeto;
    private void OnTriggerExit(Collider other) {
        NPC.GetComponent<Animator>().enabled = false;
        Objeto.SetActive(false);
    }
}
