using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basura : MonoBehaviour
{
    public GameObject BasuraModel;

    

    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        Vector3 position = BasuraModel.transform.position;

        float distance = Vector3.Distance(position, player.transform.position);
        if (distance < 1.2f)
        {
            if (Input.GetKey(KeyCode.F))
            {
                LimpiarBasura();
            }
        }
    }

    void LimpiarBasura()
    {
        BasuraModel.SetActive(false);
    }
}
