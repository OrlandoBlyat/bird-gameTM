using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhyButton : MonoBehaviour
{
    public GameObject whyCanvas;

    public void ShowWhy()
    {
        whyCanvas.SetActive(true);
    }

    public void HideWhy()
    {
        whyCanvas.SetActive(false);
    }
}
