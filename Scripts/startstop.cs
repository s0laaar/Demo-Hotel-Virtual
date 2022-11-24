using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startstop : MonoBehaviour {
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start()
    {
        GameObject.Find("Cube").GetComponent<VH>().enabled = true;
    }

    public void stop()
    {
        GameObject.Find("Cube").GetComponent<VH>().enabled = false;
    }
}
