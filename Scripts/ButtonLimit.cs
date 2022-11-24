using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLimit : MonoBehaviour
{
    /*
    public Image theButton;
    // Start is called before the first frame update
    void Start()
    {
        theButton.alphaHitTestMinimumThreshold = 0.5f;
    }
    */

    public float AlphaThreshold = 0.1f;

    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold;
    }
}
