using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivaObj : MonoBehaviour
{
    public GameObject EspejoBaño;
    public GameObject EspejoLiving;
    public GameObject ObjExtraB1;
    public GameObject ObjExtraB2;
    public GameObject ObjExtraL1;
    public GameObject ObjExtraL2;
    //public GameObject CortinasLiving;
    //public GameObject CortinasDormitorio;
    public GameObject TriggerEntraBaño;
    public GameObject TriggerSaleBaño;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //CortinasLiving = GameObject.FindGameObjectWithTag("CortinasLiv");
            //CortinasDormitorio = GameObject.FindGameObjectWithTag("CortinasDorm");
          
            EspejoBaño.SetActive(false);
            ObjExtraB1.SetActive(false);
            ObjExtraB2.SetActive(true);
            //CortinasLiving.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            EspejoLiving.SetActive(true);
            ObjExtraL1.SetActive(true);
            ObjExtraL2.SetActive(true);
            //CortinasDormitorio.SetActive(false);

            TriggerSaleBaño.SetActive(false);
            TriggerEntraBaño.SetActive(true);  

        }
    }



}
