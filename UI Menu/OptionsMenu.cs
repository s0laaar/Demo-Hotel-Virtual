using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    [Header("Options")]
    public Slider volumeFx;
    public Slider volumeMaster;
    public Toggle mute;
    public Toggle fullScreen;
    public AudioMixer mixer;
    private float lastVolume;
    public TMP_Dropdown resolucionDropdown;
    Resolution[] resoluciones;

    void Start()
    {
        //Dependiendo si el juego está en pantalla completa o no, se activa o desactiva la casilla de pantalla completa en el menú según corresponda
        if (Screen.fullScreen)
        {
            fullScreen.isOn = true;
        }
        else 
        {
            fullScreen.isOn = false;
        }

        RevisarResolucion();
        mixer.SetFloat("VolMaster", -4);
    }

    public void Awake()
    {
        //Al cambiar el valor de los sliders, se convoca a los métodos especificados
        volumeMaster.onValueChanged.AddListener(CambiarVolumeMaster);
        volumeFx.onValueChanged.AddListener(CambiarVolumeFx);
    }

    //Método que cambia el volumen del juego
    public void CambiarVolumeMaster(float v)
    {
        mixer.SetFloat("VolMaster", v);
    }

    //Método que cambia el volumen de los efectos de sonido del juego
    public void CambiarVolumeFx(float v)
    {
        mixer.SetFloat("VolFx", v);
    }

    //Método que mutea el audio del juego
    public void setMute()
    {
        if (mute.isOn)
        {
            mixer.GetFloat("VolMaster", out lastVolume);
            mixer.SetFloat("VolMaster", -80);
        }
        else
        {
            mixer.SetFloat("VolMaster", lastVolume);
        }
    }

    //Método que activa la pantalla completa
    public void ActivarPantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    //Método que captura las resoluciones disponibles del equipo del usuario y las muestra en el dropdown correspondiente en el menú
    public void RevisarResolucion()
    {
        resoluciones = Screen.resolutions;
        resolucionDropdown.ClearOptions();
        List<string> opciones = new List<string>();
        int resolucionActual = 0;

        for (int i = 0; i < resoluciones.Length; i++)
        {
            string opcion = resoluciones[i].width + "x" + resoluciones[i].height;
            opciones.Add(opcion);

            if (Screen.fullScreen && resoluciones[i].width == Screen.currentResolution.width && resoluciones[i].height == Screen.currentResolution.height)
            {
                resolucionActual = i;
            }
        }
        resolucionDropdown.AddOptions(opciones);
        resolucionDropdown.value = resolucionActual;
        resolucionDropdown.RefreshShownValue();
        resolucionDropdown.value = PlayerPrefs.GetInt("numeroResolucion", 0);
    }

    //Método que cambia la resolucion del juego
    public void CambiarResolucion(int indiceResolucion)
    {
        PlayerPrefs.SetInt("numeroResolucion", resolucionDropdown.value);
        Resolution resolucion = resoluciones[indiceResolucion];
        Screen.SetResolution(resolucion.width, resolucion.height, Screen.fullScreen);
    }
}
