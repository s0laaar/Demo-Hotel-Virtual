using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayito : MonoBehaviour
{
    public float distanceMaxima;
    [SerializeField] private LayerMask detectLayer;
    public TMPro.TextMeshProUGUI detectText;
    public GameObject TextInfoAspiradora;
    public GameObject TextItem;
    public GameObject TextLlave;

    [Header("LlaveComponents")]

    public GameObject handPoint;
    private GameObject pickedObject = null;

    public GameObject tarjeta;
    [SerializeField] private GameObject boxDetect;
    [SerializeField] private Transform zonaOrigenBoxDet;
    [SerializeField] public GameObject TextDetect;

    [Header("DesodoranteComponents")]
    public GameObject Desodorante;
    public GameObject TextDesodorante;

    public GameObject TextBasura;


    // Update is called once per frame
    void Update()
    {
        if(pickedObject!=null)
        {
            if(Input.GetMouseButton(1))
            {
                pickedObject.SetActive(false);
                pickedObject = null;
            }
        }
        
        DoRay();
    }

    void DoRay()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distanceMaxima, detectLayer))
        {
            string objectTag = hit.collider.tag;
            detectText.gameObject.SetActive(true);
            
            detectText.text = objectTag;

            switch (objectTag)
            {
                case "Cortina":
                    ActionOnCortina(hit.collider.gameObject);

                    break;
                case "Item":
                    ActionOnItem(hit.collider.gameObject);
                    
                    break;
                case "Aspiradora":
                    ActionOnAspiradora(hit.collider.gameObject);
                    
                    break;
                case "Llave":
                    ActionOnLlave(hit.collider.gameObject);
                    break;
                case "Basura":
                    ActionOnBasura(hit.collider.gameObject);
                    break;

                case "Desodorante":
                    ActionOnDesodorante(hit.collider.gameObject);
                    break;
            }
        }
        else
        {
            detectText.gameObject.SetActive(false);

            TextLlave.SetActive(false);
            TextItem.SetActive(false);
            TextInfoAspiradora.SetActive(false);
            TextDesodorante.SetActive(false);
            TextBasura.SetActive(false);
        }

         

    }

    void ActionOnLlave(GameObject _go)
    {
        TextLlave.SetActive(true);
        if(Input.GetMouseButton(0) && pickedObject == null)
        {
            tarjeta.GetComponent<Rigidbody>().useGravity = false;
            tarjeta.GetComponent<Rigidbody>().isKinematic = true;
       
            tarjeta.transform.Rotate(0.0f, 90.0f, 90.0f, Space.World); 
                       
            tarjeta.transform.position = handPoint.transform.position;
            tarjeta.gameObject.transform.SetParent(handPoint.gameObject.transform);

            pickedObject = tarjeta.gameObject; 
        }

    }

    void ActionOnDesodorante(GameObject _go)
    {
        TextDesodorante.SetActive(true);
        if (Input.GetMouseButton(0) && pickedObject == null)
        {
            
            Desodorante.GetComponent<Rigidbody>().useGravity = false;
            Desodorante.GetComponent<Rigidbody>().isKinematic = true;

            Desodorante.transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);

            Desodorante.transform.position = handPoint.transform.position;
            Desodorante.gameObject.transform.SetParent(handPoint.gameObject.transform);

            pickedObject = Desodorante.gameObject;
        }

    }

    void ActionOnCortina(GameObject _go)
    {
    }


    void ActionOnItem(GameObject _go)
    {
        //TextInfoAspiradora.SetActive(true);
    }

    void ActionOnAspiradora(GameObject _go)
    {   
        TextInfoAspiradora.SetActive(true);
        if(Input.GetKeyDown(KeyCode.E))
        {
            Aspiradora aspiradora = _go.GetComponent<Aspiradora>();
            aspiradora.UsarAspiradora();
        }
    }

    void ActionOnBasura(GameObject _go)
    {
        TextBasura.SetActive(true);
    }
}
