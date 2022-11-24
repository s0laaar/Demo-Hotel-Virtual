using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivaObj : MonoBehaviour
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
        if (other.tag == "Player" )
        {
            //CortinasLiving = GameObject.FindGameObjectWithTag("CortinasLiv");
            //CortinasDormitorio = GameObject.FindGameObjectWithTag("CortinasDorm");

            EspejoLiving.SetActive(false);
            ObjExtraL1.SetActive(false);
            ObjExtraL2.SetActive(false);
            //CortinasDormitorio.SetActive(true);
            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            EspejoBaño.SetActive(true);
            ObjExtraB1.SetActive(true);
            ObjExtraB2.SetActive(false);
            //CortinasLiving.SetActive(false);

            TriggerEntraBaño.SetActive(false);
            TriggerSaleBaño.SetActive(true);   

        }
    }


}
