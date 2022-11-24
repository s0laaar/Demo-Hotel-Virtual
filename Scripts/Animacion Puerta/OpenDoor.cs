using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] GameObject[] ObjectosQueSeActivan_arr;
    [SerializeField] GameObject[] ObjetosQueSeDesactivan_arr;
    [SerializeField] Transform visagrasTransform;
    [SerializeField] float animSpd;
    [SerializeField] bool abrirHaciaFuera;
    [Tooltip("Afuera y adentro depende del x local de la puerta, afuera -x y adentro +x")]
    [SerializeField] Transform afueraPoint, adentroPoint;

    void DesactivarYActivarObjectos()
    {
        if(ObjectosQueSeActivan_arr != null)
        {
            foreach (var item in ObjectosQueSeActivan_arr)
            {
                item.SetActive(true);
            }
        }

        if(ObjetosQueSeDesactivan_arr != null)
        {
            foreach (var item in ObjetosQueSeDesactivan_arr)
            {
                item.SetActive(false);
            }
        }
    }

    public IEnumerator AbrirPuertaCoroutine(bool _isAbrir)
    {
        DesactivarYActivarObjectos();
        yield return null;

        Vector3 inicial = visagrasTransform.localEulerAngles;
        Vector3 final = visagrasTransform.localEulerAngles;
        final.y = 0;
        if (abrirHaciaFuera) final.y = -90;

        if (!_isAbrir)
        {
            final.y = 90;
        }

        float lerp = 0;
        bool isOnAnim = true;

        Quaternion inicialRoot = Quaternion.Euler(inicial);
        Quaternion finalRoot = Quaternion.Euler(final);
        

        while (isOnAnim)
        {
            lerp += Time.deltaTime * animSpd;
            visagrasTransform.localRotation = Quaternion.Lerp(inicialRoot, finalRoot, lerp);
            if(lerp >= 1)
            {
                visagrasTransform.localEulerAngles = final;
                isOnAnim = false;
            }
            yield return null;
        }
    }

    public Vector3 ObtenerPuntoDeTerminoPersonaje(Vector3 playerPos)
    {
        Transform point = afueraPoint;
        Vector3 dis = (transform.position - playerPos).normalized;
        if (dis.x < 0) point = adentroPoint;
        return point.position;
    }

    public Vector3 ObtenerPuntoDeInicioDelPersonaje(Vector3 playerPos)
    {
        Transform point = adentroPoint;
        Vector3 dis = (transform.position - playerPos).normalized;
        if (dis.x < 0) point = afueraPoint;
        return point.position;
    }


}
