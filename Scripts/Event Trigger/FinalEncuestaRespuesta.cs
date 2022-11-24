using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalEncuestaRespuesta : MonoBehaviour
{
    public Text text;
    // Update is called once per frame
    void Update()
    {
        if(RevisaPregunta.contador == 0)
        {
            text.text = "Terrible! Tu puntuacion final fue de 0%, repite el proceso de la habitacion y toma atencion a los detalles.";
        }
        if (RevisaPregunta.contador == 1)
        {
            text.text = "Pasable! tu puntuacion final fue de 50%, se recomienda revisar la habitacion denuevo.";
        }
        if (RevisaPregunta.contador == 2)
        {
            text.text = "impresionante! Tu puntuacion final fue de 100% puedes continuar con las demas habitaciones.";
        }
    }
}
