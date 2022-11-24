using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivaObj : MonoBehaviour
{
    public GameObject EspejoBa�o;
    public GameObject EspejoLiving;
    public GameObject ObjExtraB1;
    public GameObject ObjExtraB2;
    public GameObject ObjExtraL1;
    public GameObject ObjExtraL2;
    //public GameObject CortinasLiving;
    //public GameObject CortinasDormitorio;
    public GameObject TriggerEntraBa�o;
    public GameObject TriggerSaleBa�o;

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
            EspejoBa�o.SetActive(true);
            ObjExtraB1.SetActive(true);
            ObjExtraB2.SetActive(false);
            //CortinasLiving.SetActive(false);

            TriggerEntraBa�o.SetActive(false);
            TriggerSaleBa�o.SetActive(true);   

        }
    }


}
