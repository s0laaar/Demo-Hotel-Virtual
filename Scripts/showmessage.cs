using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showmessage : MonoBehaviour
{
    public void show()
    {
        gameObject.SetActive(true);
    }

    public void dontShow()
    {
        gameObject.SetActive(false);
    }


}
