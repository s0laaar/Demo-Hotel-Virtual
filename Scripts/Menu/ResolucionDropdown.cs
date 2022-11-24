using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolucionDropdown : MonoBehaviour
{
    public Dropdown dropdownMenu;

    void Start()
    {
        dropdownMenu = GetComponent<Dropdown>();
        dropdownMenu.onValueChanged.AddListener(delegate { valueChange(dropdownMenu); });
    }

    

    public void valueChange(Dropdown change)
    {
        if (change.value == 0)
        {
            Screen.SetResolution(1920, 1080, true);
        } else if (change.value == 1)
        {
            Screen.SetResolution(1280, 720, true);
        } else if (change.value == 2)
        {
            Screen.SetResolution(800, 600, true);
        }
    }


}
