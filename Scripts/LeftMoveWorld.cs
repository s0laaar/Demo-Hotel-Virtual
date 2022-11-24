using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMoveWorld : MonoBehaviour
{
    public float spinForce;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spinForce * Time.deltaTime);
    }
    public void TurnOff()
    {
        this.enabled = false;
    }

    public void TurnOn()
    {
        this.enabled = true;
    }


}
