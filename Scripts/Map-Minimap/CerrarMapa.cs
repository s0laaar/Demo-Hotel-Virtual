using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarMapa : MonoBehaviour
{
    public PlayerCommands mapCommands;

    public void CerrarM()
    {
        mapCommands.mapEnabled = false;
    }
}
