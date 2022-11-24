using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VH : MonoBehaviour
{
    public Transform target;
    public float speed;
    //public GameObject pltfrm;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
        void Update()
        {

        
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        /*
        float step = speed * Time.deltaTime;
        pltfrm.transform.position = Vector3.MoveTowards(pltfrm.transform.position, target.position, step);
        */
    }

}