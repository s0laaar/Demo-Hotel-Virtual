using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomarObjeto : MonoBehaviour
{
    public GameObject handPoint;
    private GameObject pickedObject = null;


   
    private void Update() 
    {
        if(pickedObject!=null)
        {
            
            if(Input.GetMouseButton(1))
            {
                //pickedObject.GetComponent<Rigidbody>().useGravity = true;
                //pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                //pickedObject.gameObject.transform.SetParent(null);
                //pickedObject = null;

                pickedObject.SetActive(false);
                pickedObject = null;

            }
        }
    }

    



}
