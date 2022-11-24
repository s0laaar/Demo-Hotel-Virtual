using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoger : MonoBehaviour
{
    public LayerMask detectingLayer;
    public float maxDistance;
    RaycastHit hitInfo;

    public bool DetecteObjetoParaRecoger()
    {

        if (Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3(Screen.width * .5f, Screen.height * .5f)), out hitInfo, maxDistance, detectingLayer))
        {
            return true;
        }
        return false;
    }

    public void RecogerObjeto()
    {
        ItemObject item = hitInfo.collider.GetComponent<ItemObject>();
        item.Inventariar();
    }
}
