using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mugre : MonoBehaviour
{
    [SerializeField] Color colorLimpio, colorSucio;
    [SerializeField] MeshRenderer mesh;
    public bool estaLimpio;
    float lerp = 0;

    public void LimpiarMugre()
    {
        lerp += Time.deltaTime;
        mesh.material.color = Color.Lerp(colorSucio, colorLimpio, lerp);
        print(lerp);
        if(lerp >= 1)
        {
            estaLimpio = true;
        }
    }

}
