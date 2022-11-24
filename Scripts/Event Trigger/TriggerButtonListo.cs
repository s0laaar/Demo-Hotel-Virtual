using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButtonListo : MonoBehaviour
{

    public GameObject objetoOculto;

    public void OnTriggerExit()
    {
        objetoOculto.SetActive(false);
        AcercarseTrigger.condicional = 0;
        
    }
}
