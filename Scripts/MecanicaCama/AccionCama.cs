using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionCama : MonoBehaviour
{   
    

    public GameObject CamaOrdenada;
    public GameObject CamaArrugado;

    public GameObject ExclamacionObj;
    public GameObject TriggerActivador;
    public GameObject UI;
    public GameObject Player;

    
    private void Update() {
        Vector3 position = TriggerActivador.transform.position;
        float distance = Vector3.Distance(TriggerActivador.transform.position, Player.transform.position);
        if (distance < 2f)
        {
            if (Input.GetKey("e"))
            {
                HacerCama();
            }
        }
    }

    void HacerCama()
    {
        Destroy(CamaArrugado);  
        CamaOrdenada.SetActive(true);
        Destroy(ExclamacionObj);
        TriggerActivador.SetActive(false);
        UI.SetActive(false);
    }
}
