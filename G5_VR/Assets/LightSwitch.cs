using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{

    public GameObject bigLights;
    public GameObject smallLights;


    public void BigMode()
    {
        bigLights.SetActive(true);
        smallLights.SetActive(false);
    }

    public void SmallMode()
    {
        bigLights.SetActive(false);
        smallLights.SetActive(true);
    }
}
