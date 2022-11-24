using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    private float Speed = 1f;
    private float SlowSpeed = 0.1f;

    public Transform player;
    public static bool shouldExecuteMap;


    void Update()
    {
        // x-450  x450  z500 z-350
        float xAxisValue = Input.GetAxis("Horizontal") * Speed;
        float zAxisValue = Input.GetAxis("Vertical") * Speed;
        float xValue = 0.0f;
        float zValue = 0.0f;

        if (shouldExecuteMap == true)
        {
            if (Input.GetKey(KeyCode.W) && (transform.position.z <= 10))
            {
                zValue = Speed;
            }
            if (Input.GetKey(KeyCode.S) && (transform.position.z >= -25))
            {
                zValue = -Speed;
            }
            if (Input.GetKey(KeyCode.A) && (transform.position.x >= -40))
            {
                xValue = -Speed;
            }
            if (Input.GetKey(KeyCode.D) && (transform.position.x <= 40))
            {
                xValue = Speed;
            }
            if (Input.GetKey(KeyCode.UpArrow) && (transform.position.z <= 10))
            {
                zValue = SlowSpeed;
            }
            if (Input.GetKey(KeyCode.DownArrow) && (transform.position.z >= -25))
            {
                zValue = -SlowSpeed;
            }
            if (Input.GetKey(KeyCode.LeftArrow) && (transform.position.x >= -40))
            {
                xValue = -SlowSpeed;
            }
            if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x <= 40))
            {
                xValue = SlowSpeed;
            }

            if (Input.GetKey(KeyCode.Q))
            {
                if (GetComponent<Camera>().orthographicSize >= 30)
                {
                    GetComponent<Camera>().orthographicSize = 30;
                }
                else
                {
                    GetComponent<Camera>().orthographicSize += 0.3f;
                }
            }
            if (Input.GetKey(KeyCode.E))
            {
                if (GetComponent<Camera>().orthographicSize <= 5)
                {
                    GetComponent<Camera>().orthographicSize = 5;
                }
                else
                {
                    GetComponent<Camera>().orthographicSize -= 0.3f;
                }
            }

            if (Input.GetKey(KeyCode.R))
            {
                GetComponent<Camera>().orthographicSize = 20;
                Vector3 newPosition = player.position;
                newPosition.y = transform.position.y;
                transform.position = newPosition;
            }
            transform.position = new Vector3(transform.position.x + xValue, transform.position.y + zAxisValue, transform.position.z + zValue);
        }

        
    }
}
