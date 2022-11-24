using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.EventSystems;


public class VH2 : MonoBehaviour
{
    public GameObject pltfrm;
    public Transform target;
    public float speed;
    
    void Start()
    {
        
    }


    void Update()
    {
       
    }

    public void SigueRuta()
    {
            float step = speed * Time.deltaTime;
            pltfrm.transform.position = Vector3.MoveTowards(pltfrm.transform.position, target.position, step);
            
    }

}
