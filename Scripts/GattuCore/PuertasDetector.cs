using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertasDetector : MonoBehaviour
{    
    public LayerMask detectingLayer;
    public float maxDistance;
    RaycastHit hitInfo;

    public bool IsPuertaDetectada()
    {

        if (Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3(Screen.width * .5f, Screen.height * .5f)), out hitInfo, maxDistance, detectingLayer))
        {
            return true;
        }
        return false;
    }

    public IEnumerator EntrarAHabitacionCoroutine(PlayerMain playerMain)
    {
        OpenDoor door = hitInfo.collider.GetComponent<OpenDoor>();
        Vector3 playerEndPoint = door.ObtenerPuntoDeTerminoPersonaje(transform.position);
        Vector3 playerStartPoint = door.ObtenerPuntoDeInicioDelPersonaje(transform.position);

        playerMain.playerActivado = false;
        playerMain.playerAnim.SetAnim(0, 1);

        yield return playerMain.movement.MoveToPointCoroutine(playerStartPoint);

        playerMain.playerAnim.SetAnim(0, 0);

        yield return door.AbrirPuertaCoroutine(true);

        playerMain.playerAnim.SetAnim(0, 1);

        yield return playerMain.movement.MoveToPointCoroutine(playerEndPoint);

        playerMain.playerAnim.SetAnim(0, 0);

        yield return door.AbrirPuertaCoroutine(false);

        playerMain.playerActivado = true;
    }

    private void OnDrawGizmos()
    {
       // Gizmos.color = Color.red;
       // Gizmos.DrawRay(new Ray(new Vector3(Screen.width * .5f, Screen.height * .5f), transform.forward));
    }

}
