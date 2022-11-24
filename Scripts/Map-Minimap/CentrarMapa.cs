using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentrarMapa : MonoBehaviour
{

    public GameObject map;
    public Camera mapCamera;

    public void CentrarM()
    {
        mapCamera.orthographicSize = 20f;
        map.transform.position = new Vector3(-2, 500, -10);
    }
    
}
