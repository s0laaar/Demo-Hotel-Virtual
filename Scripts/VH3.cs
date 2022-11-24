using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VH3 : MonoBehaviour
{
    public Transform target;
    public float speed = 1;
    public GameObject pltfrm;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void SigueRuta()
    {
        pltfrm.transform.position = Vector3.MoveTowards(pltfrm.transform.position, target.position, speed * Time.deltaTime);
    }
}