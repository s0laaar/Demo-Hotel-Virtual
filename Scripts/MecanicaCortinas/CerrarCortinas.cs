using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarCortinas : MonoBehaviour
{
    public GameObject CortinasCERRADAS;
    public GameObject CortinasABIERTAS;

    public GameObject TextDetect;
    public GameObject ExclamacionObj;

    public GameObject Player;
    public GameObject TriggerActivador;
    public GameObject UI;




    private void Update(){
        Vector3 position = TriggerActivador.transform.position;
        float distance = Vector3.Distance(TriggerActivador.transform.position, Player.transform.position);
        if(distance<2f){
            if(Input.GetKey("e")){
                Cerrar();
            }
        }        
        
    }
    
    void Cerrar(){
        Destroy(CortinasABIERTAS);
        CortinasCERRADAS.SetActive(true);
        Destroy(ExclamacionObj);
        TriggerActivador.SetActive(false);  
        UI.SetActive(false);
    }

    
}
