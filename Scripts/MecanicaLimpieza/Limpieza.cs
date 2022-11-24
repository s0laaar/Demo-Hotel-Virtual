using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limpieza : MonoBehaviour
{
   public Color colorSucio, colorLimpio;
   public MeshRenderer quadMeshRenderer;

   [Range(0.0F, 1.0F)]
   public float lerp = 0;
   public float limpiezaSpd;

   private void Update() {
       if(Input.GetKey("f"))
       {
           GameObject player = GameObject.FindGameObjectWithTag("Player");
           Vector3 position = quadMeshRenderer.transform.position;

           float distance = Vector3.Distance(quadMeshRenderer.transform.position, player.transform.position);
           if(distance <3.5f)
           {
               if(lerp >= 0  && lerp < 1)
                {
                    lerp += Time.deltaTime * limpiezaSpd;
                    Limpiar();
                }
           } 
           
           
       }
   }
   
   void Limpiar()
   {
       Color actualColor = Color.Lerp(colorSucio,colorLimpio,lerp);
       quadMeshRenderer.material.color = actualColor;
   }
}
